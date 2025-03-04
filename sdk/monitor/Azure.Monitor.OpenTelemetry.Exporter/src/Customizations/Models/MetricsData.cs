﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core;
using OpenTelemetry.Metrics;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class MetricsData
    {
        public MetricsData(int version, Metric metric, MetricPoint metricPoint) : base(version)
        {
            if (metric == null)
            {
                throw new ArgumentNullException(nameof(metric));
            }

            IList<MetricDataPoint> metricDataPoints = new List<MetricDataPoint>();
            MetricDataPoint metricDataPoint = null;
            switch (metric.MetricType)
            {
                case MetricType.DoubleSum:
                    metricDataPoint = new MetricDataPoint(metric.Name, metricPoint.GetSumDouble())
                    {
                        Namespace = metric.MeterName,
                        DataPointType = DataPointType.Aggregation
                    };
                    break;
                case MetricType.DoubleGauge:
                    metricDataPoint = new MetricDataPoint(metric.Name, metricPoint.GetGaugeLastValueDouble())
                    {
                        Namespace = metric.MeterName,
                        DataPointType = DataPointType.Measurement
                    };
                    break;
                case MetricType.LongSum:
                    // potential for minor precision loss implicitly going from long->double
                    // see: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions#implicit-numeric-conversions
                    metricDataPoint = new MetricDataPoint(metric.Name, metricPoint.GetSumLong())
                    {
                        Namespace = metric.MeterName,
                        DataPointType = DataPointType.Aggregation
                    };
                    break;
                case MetricType.LongGauge:
                    // potential for minor precision loss implicitly going from long->double
                    // see: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions#implicit-numeric-conversions
                    metricDataPoint = new MetricDataPoint(metric.Name, metricPoint.GetGaugeLastValueLong())
                    {
                        Namespace = metric.MeterName,
                        DataPointType = DataPointType.Measurement
                    };
                    break;
                case MetricType.Histogram:
                    metricDataPoint = new MetricDataPoint(metric.Name, metricPoint.GetHistogramSum())
                    {
                        Namespace = metric.MeterName,
                        DataPointType = DataPointType.Aggregation
                    };

                    long histogramCount = metricPoint.GetHistogramCount();
                    // Current schema only supports int values for count
                    // if the value is within integer range we will use it otherwise ignore it.
                    metricDataPoint.Count = (histogramCount <= int.MaxValue && histogramCount >= int.MinValue) ? (int?)histogramCount : null;
                    break;
            }

            metricDataPoints.Add(metricDataPoint);
            Metrics = metricDataPoints;
            Properties = new ChangeTrackingDictionary<string, string>();
            foreach (var tag in metricPoint.Tags)
            {
                if (tag.Key.Length <= SchemaConstants.MetricsData_Properties_MaxKeyLength && tag.Value != null)
                {
                    // Note: if Key exceeds MaxLength or if Value is null, the entire KVP will be dropped.

                    Properties.Add(new KeyValuePair<string, string>(tag.Key, tag.Value.ToString().Truncate(SchemaConstants.MetricsData_Properties_MaxValueLength)));
                }
            }
        }

        internal static bool IsSupportedType(MetricType metricType) =>
            metricType switch
            {
                MetricType.DoubleGauge => true,
                MetricType.DoubleSum => true,
                MetricType.LongGauge => true,
                MetricType.LongSum => true,
                MetricType.Histogram => true,
                _ => false
            };
    }
}
