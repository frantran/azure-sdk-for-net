// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ForecastingSettings : IUtf8JsonSerializable, IJsonModel<ForecastingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ForecastingSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ForecastingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastingSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CountryOrRegionForHolidays))
            {
                if (CountryOrRegionForHolidays != null)
                {
                    writer.WritePropertyName("countryOrRegionForHolidays"u8);
                    writer.WriteStringValue(CountryOrRegionForHolidays);
                }
                else
                {
                    writer.WriteNull("countryOrRegionForHolidays");
                }
            }
            if (Optional.IsDefined(TimeColumnName))
            {
                if (TimeColumnName != null)
                {
                    writer.WritePropertyName("timeColumnName"u8);
                    writer.WriteStringValue(TimeColumnName);
                }
                else
                {
                    writer.WriteNull("timeColumnName");
                }
            }
            if (Optional.IsDefined(TargetLags))
            {
                if (TargetLags != null)
                {
                    writer.WritePropertyName("targetLags"u8);
                    writer.WriteObjectValue(TargetLags, options);
                }
                else
                {
                    writer.WriteNull("targetLags");
                }
            }
            if (Optional.IsDefined(TargetRollingWindowSize))
            {
                if (TargetRollingWindowSize != null)
                {
                    writer.WritePropertyName("targetRollingWindowSize"u8);
                    writer.WriteObjectValue(TargetRollingWindowSize, options);
                }
                else
                {
                    writer.WriteNull("targetRollingWindowSize");
                }
            }
            if (Optional.IsDefined(ForecastHorizon))
            {
                writer.WritePropertyName("forecastHorizon"u8);
                writer.WriteObjectValue(ForecastHorizon, options);
            }
            if (Optional.IsCollectionDefined(TimeSeriesIdColumnNames))
            {
                if (TimeSeriesIdColumnNames != null)
                {
                    writer.WritePropertyName("timeSeriesIdColumnNames"u8);
                    writer.WriteStartArray();
                    foreach (var item in TimeSeriesIdColumnNames)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("timeSeriesIdColumnNames");
                }
            }
            if (Optional.IsDefined(Frequency))
            {
                if (Frequency != null)
                {
                    writer.WritePropertyName("frequency"u8);
                    writer.WriteStringValue(Frequency);
                }
                else
                {
                    writer.WriteNull("frequency");
                }
            }
            if (Optional.IsDefined(FeatureLags))
            {
                writer.WritePropertyName("featureLags"u8);
                writer.WriteStringValue(FeatureLags.Value.ToString());
            }
            if (Optional.IsDefined(Seasonality))
            {
                writer.WritePropertyName("seasonality"u8);
                writer.WriteObjectValue(Seasonality, options);
            }
            if (Optional.IsDefined(ShortSeriesHandlingConfig))
            {
                writer.WritePropertyName("shortSeriesHandlingConfig"u8);
                writer.WriteStringValue(ShortSeriesHandlingConfig.Value.ToString());
            }
            if (Optional.IsDefined(UseStl))
            {
                writer.WritePropertyName("useStl"u8);
                writer.WriteStringValue(UseStl.Value.ToString());
            }
            if (Optional.IsDefined(TargetAggregateFunction))
            {
                writer.WritePropertyName("targetAggregateFunction"u8);
                writer.WriteStringValue(TargetAggregateFunction.Value.ToString());
            }
            if (Optional.IsDefined(CvStepSize))
            {
                if (CvStepSize != null)
                {
                    writer.WritePropertyName("cvStepSize"u8);
                    writer.WriteNumberValue(CvStepSize.Value);
                }
                else
                {
                    writer.WriteNull("cvStepSize");
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

        ForecastingSettings IJsonModel<ForecastingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastingSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeForecastingSettings(document.RootElement, options);
        }

        internal static ForecastingSettings DeserializeForecastingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string countryOrRegionForHolidays = default;
            string timeColumnName = default;
            TargetLags targetLags = default;
            TargetRollingWindowSize targetRollingWindowSize = default;
            ForecastHorizon forecastHorizon = default;
            IList<string> timeSeriesIdColumnNames = default;
            string frequency = default;
            MachineLearningFeatureLag? featureLags = default;
            ForecastingSeasonality seasonality = default;
            MachineLearningShortSeriesHandlingConfiguration? shortSeriesHandlingConfig = default;
            MachineLearningUseStl? useStl = default;
            TargetAggregationFunction? targetAggregateFunction = default;
            int? cvStepSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countryOrRegionForHolidays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        countryOrRegionForHolidays = null;
                        continue;
                    }
                    countryOrRegionForHolidays = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeColumnName = null;
                        continue;
                    }
                    timeColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetLags = null;
                        continue;
                    }
                    targetLags = TargetLags.DeserializeTargetLags(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetRollingWindowSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetRollingWindowSize = null;
                        continue;
                    }
                    targetRollingWindowSize = TargetRollingWindowSize.DeserializeTargetRollingWindowSize(property.Value, options);
                    continue;
                }
                if (property.NameEquals("forecastHorizon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forecastHorizon = ForecastHorizon.DeserializeForecastHorizon(property.Value, options);
                    continue;
                }
                if (property.NameEquals("timeSeriesIdColumnNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeSeriesIdColumnNames = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    timeSeriesIdColumnNames = array;
                    continue;
                }
                if (property.NameEquals("frequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        frequency = null;
                        continue;
                    }
                    frequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("featureLags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featureLags = new MachineLearningFeatureLag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("seasonality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    seasonality = ForecastingSeasonality.DeserializeForecastingSeasonality(property.Value, options);
                    continue;
                }
                if (property.NameEquals("shortSeriesHandlingConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shortSeriesHandlingConfig = new MachineLearningShortSeriesHandlingConfiguration(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useStl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useStl = new MachineLearningUseStl(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAggregateFunction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAggregateFunction = new TargetAggregationFunction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cvStepSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvStepSize = null;
                        continue;
                    }
                    cvStepSize = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ForecastingSettings(
                countryOrRegionForHolidays,
                timeColumnName,
                targetLags,
                targetRollingWindowSize,
                forecastHorizon,
                timeSeriesIdColumnNames ?? new ChangeTrackingList<string>(),
                frequency,
                featureLags,
                seasonality,
                shortSeriesHandlingConfig,
                useStl,
                targetAggregateFunction,
                cvStepSize,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CountryOrRegionForHolidays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  countryOrRegionForHolidays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CountryOrRegionForHolidays))
                {
                    builder.Append("  countryOrRegionForHolidays: ");
                    if (CountryOrRegionForHolidays.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CountryOrRegionForHolidays}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CountryOrRegionForHolidays}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeColumnName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeColumnName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeColumnName))
                {
                    builder.Append("  timeColumnName: ");
                    if (TimeColumnName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TimeColumnName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TimeColumnName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetLags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetLags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetLags))
                {
                    builder.Append("  targetLags: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TargetLags, options, 2, false, "  targetLags: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetRollingWindowSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetRollingWindowSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetRollingWindowSize))
                {
                    builder.Append("  targetRollingWindowSize: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TargetRollingWindowSize, options, 2, false, "  targetRollingWindowSize: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ForecastHorizon), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  forecastHorizon: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ForecastHorizon))
                {
                    builder.Append("  forecastHorizon: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ForecastHorizon, options, 2, false, "  forecastHorizon: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeSeriesIdColumnNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeSeriesIdColumnNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(TimeSeriesIdColumnNames))
                {
                    if (TimeSeriesIdColumnNames.Any())
                    {
                        builder.Append("  timeSeriesIdColumnNames: ");
                        builder.AppendLine("[");
                        foreach (var item in TimeSeriesIdColumnNames)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Frequency), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  frequency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Frequency))
                {
                    builder.Append("  frequency: ");
                    if (Frequency.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Frequency}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Frequency}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FeatureLags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  featureLags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FeatureLags))
                {
                    builder.Append("  featureLags: ");
                    builder.AppendLine($"'{FeatureLags.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Seasonality), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  seasonality: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Seasonality))
                {
                    builder.Append("  seasonality: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Seasonality, options, 2, false, "  seasonality: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ShortSeriesHandlingConfig), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  shortSeriesHandlingConfig: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ShortSeriesHandlingConfig))
                {
                    builder.Append("  shortSeriesHandlingConfig: ");
                    builder.AppendLine($"'{ShortSeriesHandlingConfig.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UseStl), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  useStl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UseStl))
                {
                    builder.Append("  useStl: ");
                    builder.AppendLine($"'{UseStl.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetAggregateFunction), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetAggregateFunction: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetAggregateFunction))
                {
                    builder.Append("  targetAggregateFunction: ");
                    builder.AppendLine($"'{TargetAggregateFunction.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CvStepSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cvStepSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CvStepSize))
                {
                    builder.Append("  cvStepSize: ");
                    builder.AppendLine($"{CvStepSize.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ForecastingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ForecastingSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ForecastingSettings IPersistableModel<ForecastingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeForecastingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ForecastingSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ForecastingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
