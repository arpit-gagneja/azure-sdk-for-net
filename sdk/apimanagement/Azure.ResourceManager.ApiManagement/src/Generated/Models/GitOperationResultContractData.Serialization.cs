// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class GitOperationResultContractData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OperationResultIdentifier))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(OperationResultIdentifier);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("started");
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updated");
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(ResultInfo))
            {
                writer.WritePropertyName("resultInfo");
                writer.WriteStringValue(ResultInfo);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error");
                writer.WriteObjectValue(Error);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static GitOperationResultContractData DeserializeGitOperationResultContractData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> id0 = default;
            Optional<AsyncOperationStatus> status = default;
            Optional<DateTimeOffset> started = default;
            Optional<DateTimeOffset> updated = default;
            Optional<string> resultInfo = default;
            Optional<ErrorResponseBody> error = default;
            Optional<IReadOnlyList<OperationResultLogItemContract>> actionLog = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("id"))
                        {
                            id0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetString().ToAsyncOperationStatus();
                            continue;
                        }
                        if (property0.NameEquals("started"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            started = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updated"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("resultInfo"))
                        {
                            resultInfo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            error = ErrorResponseBody.DeserializeErrorResponseBody(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("actionLog"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<OperationResultLogItemContract> array = new List<OperationResultLogItemContract>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(OperationResultLogItemContract.DeserializeOperationResultLogItemContract(item));
                            }
                            actionLog = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new GitOperationResultContractData(id, name, type, systemData.Value, id0.Value, Optional.ToNullable(status), Optional.ToNullable(started), Optional.ToNullable(updated), resultInfo.Value, error.Value, Optional.ToList(actionLog));
        }
    }
}
