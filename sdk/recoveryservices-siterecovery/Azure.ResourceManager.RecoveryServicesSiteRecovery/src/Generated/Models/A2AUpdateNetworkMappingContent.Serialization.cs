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
    public partial class A2AUpdateNetworkMappingContent : IUtf8JsonSerializable, IJsonModel<A2AUpdateNetworkMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AUpdateNetworkMappingContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<A2AUpdateNetworkMappingContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUpdateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AUpdateNetworkMappingContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(PrimaryNetworkId))
            {
                writer.WritePropertyName("primaryNetworkId"u8);
                writer.WriteStringValue(PrimaryNetworkId);
            }
        }

        A2AUpdateNetworkMappingContent IJsonModel<A2AUpdateNetworkMappingContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUpdateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AUpdateNetworkMappingContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AUpdateNetworkMappingContent(document.RootElement, options);
        }

        internal static A2AUpdateNetworkMappingContent DeserializeA2AUpdateNetworkMappingContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier primaryNetworkId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryNetworkId = new ResourceIdentifier(property.Value.GetString());
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
            return new A2AUpdateNetworkMappingContent(instanceType, serializedAdditionalRawData, primaryNetworkId);
        }

        BinaryData IPersistableModel<A2AUpdateNetworkMappingContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUpdateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AUpdateNetworkMappingContent)} does not support writing '{options.Format}' format.");
            }
        }

        A2AUpdateNetworkMappingContent IPersistableModel<A2AUpdateNetworkMappingContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUpdateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AUpdateNetworkMappingContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AUpdateNetworkMappingContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AUpdateNetworkMappingContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
