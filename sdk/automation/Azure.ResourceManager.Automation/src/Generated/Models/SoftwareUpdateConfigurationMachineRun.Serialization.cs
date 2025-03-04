// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationMachineRun
    {
        internal static SoftwareUpdateConfigurationMachineRun DeserializeSoftwareUpdateConfigurationMachineRun(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> targetComputer = default;
            Optional<string> targetComputerType = default;
            Optional<UpdateConfigurationNavigation> softwareUpdateConfiguration = default;
            Optional<string> status = default;
            Optional<string> osType = default;
            Optional<Guid> correlationId = default;
            Optional<Guid> sourceComputerId = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            Optional<TimeSpan> configuredDuration = default;
            Optional<SubResource> job = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> createdBy = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> lastModifiedBy = default;
            Optional<ErrorResponse> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetComputer"))
                        {
                            targetComputer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetComputerType"))
                        {
                            targetComputerType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("softwareUpdateConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            softwareUpdateConfiguration = UpdateConfigurationNavigation.DeserializeUpdateConfigurationNavigation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            osType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlationId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            correlationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("sourceComputerId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceComputerId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                endTime = null;
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("configuredDuration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            configuredDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("job"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            job = JsonSerializer.Deserialize<SubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"))
                        {
                            createdBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            error = ErrorResponse.DeserializeErrorResponse(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SoftwareUpdateConfigurationMachineRun(name.Value, id.Value, targetComputer.Value, targetComputerType.Value, softwareUpdateConfiguration.Value, status.Value, osType.Value, Optional.ToNullable(correlationId), Optional.ToNullable(sourceComputerId), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(configuredDuration), job, Optional.ToNullable(creationTime), createdBy.Value, Optional.ToNullable(lastModifiedTime), lastModifiedBy.Value, error.Value);
        }
    }
}
