// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    internal partial class AvailabilityGroupConfiguration : IUtf8JsonSerializable, IJsonModel<AvailabilityGroupConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailabilityGroupConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvailabilityGroupConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Replicas))
            {
                writer.WritePropertyName("replicas"u8);
                writer.WriteStartArray();
                foreach (var item in Replicas)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AvailabilityGroupConfiguration IJsonModel<AvailabilityGroupConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityGroupConfiguration(document.RootElement, options);
        }

        internal static AvailabilityGroupConfiguration DeserializeAvailabilityGroupConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AvailabilityGroupReplica> replicas = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailabilityGroupReplica> array = new List<AvailabilityGroupReplica>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailabilityGroupReplica.DeserializeAvailabilityGroupReplica(item, options));
                    }
                    replicas = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvailabilityGroupConfiguration(replicas ?? new ChangeTrackingList<AvailabilityGroupReplica>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailabilityGroupConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailabilityGroupConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        AvailabilityGroupConfiguration IPersistableModel<AvailabilityGroupConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailabilityGroupConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailabilityGroupConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailabilityGroupConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
