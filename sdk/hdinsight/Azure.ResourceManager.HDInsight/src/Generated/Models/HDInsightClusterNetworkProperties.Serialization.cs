// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterNetworkProperties : IUtf8JsonSerializable, IJsonModel<HDInsightClusterNetworkProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterNetworkProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightClusterNetworkProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterNetworkProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OutboundDependenciesManagedType))
            {
                writer.WritePropertyName("outboundDependenciesManagedType"u8);
                writer.WriteStringValue(OutboundDependenciesManagedType.Value.ToString());
            }
            if (Optional.IsDefined(ResourceProviderConnection))
            {
                writer.WritePropertyName("resourceProviderConnection"u8);
                writer.WriteStringValue(ResourceProviderConnection.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLink))
            {
                writer.WritePropertyName("privateLink"u8);
                writer.WriteStringValue(PrivateLink.Value.ToString());
            }
            if (Optional.IsDefined(PublicIPTag))
            {
                writer.WritePropertyName("publicIpTag"u8);
                writer.WriteObjectValue(PublicIPTag, options);
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

        HDInsightClusterNetworkProperties IJsonModel<HDInsightClusterNetworkProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterNetworkProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterNetworkProperties(document.RootElement, options);
        }

        internal static HDInsightClusterNetworkProperties DeserializeHDInsightClusterNetworkProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OutboundDependenciesManagedType? outboundDependenciesManagedType = default;
            HDInsightResourceProviderConnection? resourceProviderConnection = default;
            HDInsightPrivateLinkState? privateLink = default;
            HDInsightClusterIPTag publicIPTag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outboundDependenciesManagedType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundDependenciesManagedType = new OutboundDependenciesManagedType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceProviderConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceProviderConnection = new HDInsightResourceProviderConnection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLink = new HDInsightPrivateLinkState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIpTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPTag = HDInsightClusterIPTag.DeserializeHDInsightClusterIPTag(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightClusterNetworkProperties(outboundDependenciesManagedType, resourceProviderConnection, privateLink, publicIPTag, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterNetworkProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterNetworkProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightClusterNetworkProperties IPersistableModel<HDInsightClusterNetworkProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightClusterNetworkProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterNetworkProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterNetworkProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
