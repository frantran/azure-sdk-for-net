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
    public partial class TestFailoverJobDetails : IUtf8JsonSerializable, IJsonModel<TestFailoverJobDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TestFailoverJobDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TestFailoverJobDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestFailoverJobDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(TestFailoverStatus))
            {
                writer.WritePropertyName("testFailoverStatus"u8);
                writer.WriteStringValue(TestFailoverStatus);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(NetworkName))
            {
                writer.WritePropertyName("networkName"u8);
                writer.WriteStringValue(NetworkName);
            }
            if (Optional.IsDefined(NetworkFriendlyName))
            {
                writer.WritePropertyName("networkFriendlyName"u8);
                writer.WriteStringValue(NetworkFriendlyName);
            }
            if (Optional.IsDefined(NetworkType))
            {
                writer.WritePropertyName("networkType"u8);
                writer.WriteStringValue(NetworkType);
            }
            if (Optional.IsCollectionDefined(ProtectedItemDetails))
            {
                writer.WritePropertyName("protectedItemDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedItemDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        TestFailoverJobDetails IJsonModel<TestFailoverJobDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestFailoverJobDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTestFailoverJobDetails(document.RootElement, options);
        }

        internal static TestFailoverJobDetails DeserializeTestFailoverJobDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string testFailoverStatus = default;
            string comments = default;
            string networkName = default;
            string networkFriendlyName = default;
            string networkType = default;
            IReadOnlyList<FailoverReplicationProtectedItemDetails> protectedItemDetails = default;
            string instanceType = default;
            IReadOnlyDictionary<string, string> affectedObjectDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("testFailoverStatus"u8))
                {
                    testFailoverStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("comments"u8))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkName"u8))
                {
                    networkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFriendlyName"u8))
                {
                    networkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkType"u8))
                {
                    networkType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FailoverReplicationProtectedItemDetails> array = new List<FailoverReplicationProtectedItemDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FailoverReplicationProtectedItemDetails.DeserializeFailoverReplicationProtectedItemDetails(item, options));
                    }
                    protectedItemDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    affectedObjectDetails = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TestFailoverJobDetails(
                instanceType,
                affectedObjectDetails ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                testFailoverStatus,
                comments,
                networkName,
                networkFriendlyName,
                networkType,
                protectedItemDetails ?? new ChangeTrackingList<FailoverReplicationProtectedItemDetails>());
        }

        BinaryData IPersistableModel<TestFailoverJobDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TestFailoverJobDetails)} does not support writing '{options.Format}' format.");
            }
        }

        TestFailoverJobDetails IPersistableModel<TestFailoverJobDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTestFailoverJobDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TestFailoverJobDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TestFailoverJobDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
