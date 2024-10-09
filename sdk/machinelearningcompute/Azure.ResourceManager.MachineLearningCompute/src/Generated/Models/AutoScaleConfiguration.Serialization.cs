// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class AutoScaleConfiguration : IUtf8JsonSerializable, IJsonModel<AutoScaleConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoScaleConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutoScaleConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoScaleConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(MinReplicas))
            {
                writer.WritePropertyName("minReplicas"u8);
                writer.WriteNumberValue(MinReplicas.Value);
            }
            if (Optional.IsDefined(MaxReplicas))
            {
                writer.WritePropertyName("maxReplicas"u8);
                writer.WriteNumberValue(MaxReplicas.Value);
            }
            if (Optional.IsDefined(TargetUtilization))
            {
                writer.WritePropertyName("targetUtilization"u8);
                writer.WriteNumberValue(TargetUtilization.Value);
            }
            if (Optional.IsDefined(RefreshPeriodInSeconds))
            {
                writer.WritePropertyName("refreshPeriodInSeconds"u8);
                writer.WriteNumberValue(RefreshPeriodInSeconds.Value);
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

        AutoScaleConfiguration IJsonModel<AutoScaleConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoScaleConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoScaleConfiguration(document.RootElement, options);
        }

        internal static AutoScaleConfiguration DeserializeAutoScaleConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Status? status = default;
            int? minReplicas = default;
            int? maxReplicas = default;
            float? targetUtilization = default;
            int? refreshPeriodInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new Status(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetUtilization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetUtilization = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("refreshPeriodInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshPeriodInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutoScaleConfiguration(
                status,
                minReplicas,
                maxReplicas,
                targetUtilization,
                refreshPeriodInSeconds,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoScaleConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoScaleConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        AutoScaleConfiguration IPersistableModel<AutoScaleConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoScaleConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoScaleConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoScaleConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
