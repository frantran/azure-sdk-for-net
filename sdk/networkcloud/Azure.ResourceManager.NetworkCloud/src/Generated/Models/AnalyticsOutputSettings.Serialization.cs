// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class AnalyticsOutputSettings : IUtf8JsonSerializable, IJsonModel<AnalyticsOutputSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyticsOutputSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalyticsOutputSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyticsOutputSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyticsOutputSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AnalyticsWorkspaceId))
            {
                writer.WritePropertyName("analyticsWorkspaceId"u8);
                writer.WriteStringValue(AnalyticsWorkspaceId);
            }
            if (Optional.IsDefined(AssociatedIdentity))
            {
                writer.WritePropertyName("associatedIdentity"u8);
                writer.WriteObjectValue(AssociatedIdentity, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AnalyticsOutputSettings IJsonModel<AnalyticsOutputSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyticsOutputSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyticsOutputSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyticsOutputSettings(document.RootElement, options);
        }

        internal static AnalyticsOutputSettings DeserializeAnalyticsOutputSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier analyticsWorkspaceId = default;
            ManagedServiceIdentitySelector associatedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("analyticsWorkspaceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticsWorkspaceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("associatedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    associatedIdentity = ManagedServiceIdentitySelector.DeserializeManagedServiceIdentitySelector(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AnalyticsOutputSettings(analyticsWorkspaceId, associatedIdentity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyticsOutputSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyticsOutputSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyticsOutputSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AnalyticsOutputSettings IPersistableModel<AnalyticsOutputSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyticsOutputSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAnalyticsOutputSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyticsOutputSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyticsOutputSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
