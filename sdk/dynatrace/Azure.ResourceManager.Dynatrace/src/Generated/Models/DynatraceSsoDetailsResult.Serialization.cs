// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceSsoDetailsResult : IUtf8JsonSerializable, IJsonModel<DynatraceSsoDetailsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceSsoDetailsResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DynatraceSsoDetailsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSsoDetailsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceSsoDetailsResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsSsoEnabled))
            {
                writer.WritePropertyName("isSsoEnabled"u8);
                writer.WriteStringValue(IsSsoEnabled.Value.ToString());
            }
            if (Optional.IsDefined(MetadataUri))
            {
                writer.WritePropertyName("metadataUrl"u8);
                writer.WriteStringValue(MetadataUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SingleSignOnUri))
            {
                writer.WritePropertyName("singleSignOnUrl"u8);
                writer.WriteStringValue(SingleSignOnUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(AadDomains))
            {
                writer.WritePropertyName("aadDomains"u8);
                writer.WriteStartArray();
                foreach (var item in AadDomains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdminUsers))
            {
                writer.WritePropertyName("adminUsers"u8);
                writer.WriteStartArray();
                foreach (var item in AdminUsers)
                {
                    writer.WriteStringValue(item);
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

        DynatraceSsoDetailsResult IJsonModel<DynatraceSsoDetailsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSsoDetailsResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceSsoDetailsResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceSsoDetailsResult(document.RootElement, options);
        }

        internal static DynatraceSsoDetailsResult DeserializeDynatraceSsoDetailsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DynatraceSsoStatus? isSsoEnabled = default;
            Uri metadataUrl = default;
            Uri singleSignOnUrl = default;
            IReadOnlyList<string> aadDomains = default;
            IReadOnlyList<string> adminUsers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSsoEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSsoEnabled = new DynatraceSsoStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadataUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadataUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("singleSignOnUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadDomains"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    aadDomains = array;
                    continue;
                }
                if (property.NameEquals("adminUsers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    adminUsers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DynatraceSsoDetailsResult(
                isSsoEnabled,
                metadataUrl,
                singleSignOnUrl,
                aadDomains ?? new ChangeTrackingList<string>(),
                adminUsers ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceSsoDetailsResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSsoDetailsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynatraceSsoDetailsResult)} does not support writing '{options.Format}' format.");
            }
        }

        DynatraceSsoDetailsResult IPersistableModel<DynatraceSsoDetailsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSsoDetailsResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynatraceSsoDetailsResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceSsoDetailsResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceSsoDetailsResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
