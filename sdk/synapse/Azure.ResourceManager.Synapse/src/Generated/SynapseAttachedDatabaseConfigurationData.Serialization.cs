// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseAttachedDatabaseConfigurationData : IUtf8JsonSerializable, IJsonModel<SynapseAttachedDatabaseConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseAttachedDatabaseConfigurationData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseAttachedDatabaseConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseAttachedDatabaseConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseAttachedDatabaseConfigurationData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(KustoPoolResourceId))
            {
                writer.WritePropertyName("clusterResourceId"u8);
                writer.WriteStringValue(KustoPoolResourceId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AttachedDatabaseNames))
            {
                writer.WritePropertyName("attachedDatabaseNames"u8);
                writer.WriteStartArray();
                foreach (var item in AttachedDatabaseNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultPrincipalsModificationKind))
            {
                writer.WritePropertyName("defaultPrincipalsModificationKind"u8);
                writer.WriteStringValue(DefaultPrincipalsModificationKind.Value.ToString());
            }
            if (Optional.IsDefined(TableLevelSharingProperties))
            {
                writer.WritePropertyName("tableLevelSharingProperties"u8);
                writer.WriteObjectValue(TableLevelSharingProperties, options);
            }
            writer.WriteEndObject();
        }

        SynapseAttachedDatabaseConfigurationData IJsonModel<SynapseAttachedDatabaseConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseAttachedDatabaseConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseAttachedDatabaseConfigurationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseAttachedDatabaseConfigurationData(document.RootElement, options);
        }

        internal static SynapseAttachedDatabaseConfigurationData DeserializeSynapseAttachedDatabaseConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceProvisioningState? provisioningState = default;
            string databaseName = default;
            ResourceIdentifier clusterResourceId = default;
            IReadOnlyList<string> attachedDatabaseNames = default;
            SynapseDefaultPrincipalsModificationKind? defaultPrincipalsModificationKind = default;
            SynapseTableLevelSharingProperties tableLevelSharingProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("attachedDatabaseNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
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
                        if (property0.NameEquals("defaultPrincipalsModificationKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultPrincipalsModificationKind = new SynapseDefaultPrincipalsModificationKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tableLevelSharingProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tableLevelSharingProperties = SynapseTableLevelSharingProperties.DeserializeSynapseTableLevelSharingProperties(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseAttachedDatabaseConfigurationData(
                id,
                name,
                type,
                systemData,
                location,
                provisioningState,
                databaseName,
                clusterResourceId,
                attachedDatabaseNames ?? new ChangeTrackingList<string>(),
                defaultPrincipalsModificationKind,
                tableLevelSharingProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseAttachedDatabaseConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseAttachedDatabaseConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseAttachedDatabaseConfigurationData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseAttachedDatabaseConfigurationData IPersistableModel<SynapseAttachedDatabaseConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseAttachedDatabaseConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseAttachedDatabaseConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseAttachedDatabaseConfigurationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseAttachedDatabaseConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
