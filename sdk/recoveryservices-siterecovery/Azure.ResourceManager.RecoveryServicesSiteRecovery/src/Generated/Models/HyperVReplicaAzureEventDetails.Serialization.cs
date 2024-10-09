// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaAzureEventDetails : IUtf8JsonSerializable, IJsonModel<HyperVReplicaAzureEventDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaAzureEventDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HyperVReplicaAzureEventDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureEventDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureEventDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(FabricName))
            {
                writer.WritePropertyName("fabricName"u8);
                writer.WriteStringValue(FabricName);
            }
            if (Optional.IsDefined(RemoteContainerName))
            {
                writer.WritePropertyName("remoteContainerName"u8);
                writer.WriteStringValue(RemoteContainerName);
            }
        }

        HyperVReplicaAzureEventDetails IJsonModel<HyperVReplicaAzureEventDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureEventDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureEventDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureEventDetails(document.RootElement, options);
        }

        internal static HyperVReplicaAzureEventDetails DeserializeHyperVReplicaAzureEventDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string containerName = default;
            string fabricName = default;
            string remoteContainerName = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    fabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteContainerName"u8))
                {
                    remoteContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HyperVReplicaAzureEventDetails(instanceType, serializedAdditionalRawData, containerName, fabricName, remoteContainerName);
        }

        BinaryData IPersistableModel<HyperVReplicaAzureEventDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureEventDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureEventDetails)} does not support writing '{options.Format}' format.");
            }
        }

        HyperVReplicaAzureEventDetails IPersistableModel<HyperVReplicaAzureEventDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureEventDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVReplicaAzureEventDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureEventDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVReplicaAzureEventDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
