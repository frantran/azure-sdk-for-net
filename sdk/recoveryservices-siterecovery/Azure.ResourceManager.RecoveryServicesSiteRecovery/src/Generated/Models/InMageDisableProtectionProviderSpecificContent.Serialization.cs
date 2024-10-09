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
    public partial class InMageDisableProtectionProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<InMageDisableProtectionProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageDisableProtectionProviderSpecificContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InMageDisableProtectionProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDisableProtectionProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageDisableProtectionProviderSpecificContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ReplicaVmDeletionStatus))
            {
                writer.WritePropertyName("replicaVmDeletionStatus"u8);
                writer.WriteStringValue(ReplicaVmDeletionStatus);
            }
        }

        InMageDisableProtectionProviderSpecificContent IJsonModel<InMageDisableProtectionProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDisableProtectionProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageDisableProtectionProviderSpecificContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageDisableProtectionProviderSpecificContent(document.RootElement, options);
        }

        internal static InMageDisableProtectionProviderSpecificContent DeserializeInMageDisableProtectionProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string replicaVmDeletionStatus = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicaVmDeletionStatus"u8))
                {
                    replicaVmDeletionStatus = property.Value.GetString();
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
            return new InMageDisableProtectionProviderSpecificContent(instanceType, serializedAdditionalRawData, replicaVmDeletionStatus);
        }

        BinaryData IPersistableModel<InMageDisableProtectionProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDisableProtectionProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageDisableProtectionProviderSpecificContent)} does not support writing '{options.Format}' format.");
            }
        }

        InMageDisableProtectionProviderSpecificContent IPersistableModel<InMageDisableProtectionProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDisableProtectionProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageDisableProtectionProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageDisableProtectionProviderSpecificContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageDisableProtectionProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
