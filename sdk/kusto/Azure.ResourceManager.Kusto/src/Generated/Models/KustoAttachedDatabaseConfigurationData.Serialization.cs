// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto
{
    public partial class KustoAttachedDatabaseConfigurationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName");
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(ClusterResourceId))
            {
                writer.WritePropertyName("clusterResourceId");
                writer.WriteStringValue(ClusterResourceId);
            }
            if (Optional.IsDefined(DefaultPrincipalsModificationKind))
            {
                writer.WritePropertyName("defaultPrincipalsModificationKind");
                writer.WriteStringValue(DefaultPrincipalsModificationKind.Value.ToString());
            }
            if (Optional.IsDefined(TableLevelSharingProperties))
            {
                writer.WritePropertyName("tableLevelSharingProperties");
                writer.WriteObjectValue(TableLevelSharingProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static KustoAttachedDatabaseConfigurationData DeserializeKustoAttachedDatabaseConfigurationData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<KustoProvisioningState> provisioningState = default;
            Optional<string> databaseName = default;
            Optional<ResourceIdentifier> clusterResourceId = default;
            Optional<IReadOnlyList<string>> attachedDatabaseNames = default;
            Optional<KustoDatabaseDefaultPrincipalsModificationKind> defaultPrincipalsModificationKind = default;
            Optional<KustoDatabaseTableLevelSharingProperties> tableLevelSharingProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new KustoProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("databaseName"))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("attachedDatabaseNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            attachedDatabaseNames = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultPrincipalsModificationKind"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultPrincipalsModificationKind = new KustoDatabaseDefaultPrincipalsModificationKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tableLevelSharingProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tableLevelSharingProperties = KustoDatabaseTableLevelSharingProperties.DeserializeKustoDatabaseTableLevelSharingProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new KustoAttachedDatabaseConfigurationData(id, name, type, systemData.Value, Optional.ToNullable(location), Optional.ToNullable(provisioningState), databaseName.Value, clusterResourceId.Value, Optional.ToList(attachedDatabaseNames), Optional.ToNullable(defaultPrincipalsModificationKind), tableLevelSharingProperties.Value);
        }
    }
}
