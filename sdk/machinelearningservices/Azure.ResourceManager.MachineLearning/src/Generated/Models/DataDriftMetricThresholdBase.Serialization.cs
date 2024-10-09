// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownDataDriftMetricThresholdBase))]
    public partial class DataDriftMetricThresholdBase : IUtf8JsonSerializable, IJsonModel<DataDriftMetricThresholdBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataDriftMetricThresholdBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataDriftMetricThresholdBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataDriftMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataDriftMetricThresholdBase)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("dataType"u8);
            writer.WriteStringValue(DataType.ToString());
            if (Optional.IsDefined(Threshold))
            {
                if (Threshold != null)
                {
                    writer.WritePropertyName("threshold"u8);
                    writer.WriteObjectValue(Threshold, options);
                }
                else
                {
                    writer.WriteNull("threshold");
                }
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

        DataDriftMetricThresholdBase IJsonModel<DataDriftMetricThresholdBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataDriftMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataDriftMetricThresholdBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataDriftMetricThresholdBase(document.RootElement, options);
        }

        internal static DataDriftMetricThresholdBase DeserializeDataDriftMetricThresholdBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("dataType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Categorical": return CategoricalDataDriftMetricThreshold.DeserializeCategoricalDataDriftMetricThreshold(element, options);
                    case "Numerical": return NumericalDataDriftMetricThreshold.DeserializeNumericalDataDriftMetricThreshold(element, options);
                }
            }
            return UnknownDataDriftMetricThresholdBase.DeserializeUnknownDataDriftMetricThresholdBase(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dataType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  dataType: ");
                builder.AppendLine($"'{DataType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("ThresholdValue", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  threshold: ");
                builder.AppendLine("{");
                builder.Append("    value: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Threshold))
                {
                    builder.Append("  threshold: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Threshold, options, 2, false, "  threshold: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DataDriftMetricThresholdBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataDriftMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataDriftMetricThresholdBase)} does not support writing '{options.Format}' format.");
            }
        }

        DataDriftMetricThresholdBase IPersistableModel<DataDriftMetricThresholdBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataDriftMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataDriftMetricThresholdBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataDriftMetricThresholdBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataDriftMetricThresholdBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
