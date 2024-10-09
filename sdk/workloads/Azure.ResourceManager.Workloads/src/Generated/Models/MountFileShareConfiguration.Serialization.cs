// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class MountFileShareConfiguration : IUtf8JsonSerializable, IJsonModel<MountFileShareConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MountFileShareConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MountFileShareConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MountFileShareConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MountFileShareConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(FileShareId);
            writer.WritePropertyName("privateEndpointId"u8);
            writer.WriteStringValue(PrivateEndpointId);
        }

        MountFileShareConfiguration IJsonModel<MountFileShareConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MountFileShareConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MountFileShareConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMountFileShareConfiguration(document.RootElement, options);
        }

        internal static MountFileShareConfiguration DeserializeMountFileShareConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            ResourceIdentifier privateEndpointId = default;
            ConfigurationType configurationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointId"u8))
                {
                    privateEndpointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new ConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MountFileShareConfiguration(configurationType, serializedAdditionalRawData, id, privateEndpointId);
        }

        BinaryData IPersistableModel<MountFileShareConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MountFileShareConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MountFileShareConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        MountFileShareConfiguration IPersistableModel<MountFileShareConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MountFileShareConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMountFileShareConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MountFileShareConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MountFileShareConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
