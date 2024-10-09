// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ScheduledQueryRuleCondition : IUtf8JsonSerializable, IJsonModel<ScheduledQueryRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduledQueryRuleCondition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScheduledQueryRuleCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledQueryRuleCondition)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(TimeAggregation))
            {
                writer.WritePropertyName("timeAggregation"u8);
                writer.WriteStringValue(TimeAggregation.Value.ToString());
            }
            if (Optional.IsDefined(MetricMeasureColumn))
            {
                writer.WritePropertyName("metricMeasureColumn"u8);
                writer.WriteStringValue(MetricMeasureColumn);
            }
            if (Optional.IsDefined(ResourceIdColumn))
            {
                writer.WritePropertyName("resourceIdColumn"u8);
                writer.WriteStringValue(ResourceIdColumn);
            }
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToSerialString());
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteNumberValue(Threshold.Value);
            }
            if (Optional.IsDefined(FailingPeriods))
            {
                writer.WritePropertyName("failingPeriods"u8);
                writer.WriteObjectValue(FailingPeriods, options);
            }
            if (Optional.IsDefined(MetricName))
            {
                writer.WritePropertyName("metricName"u8);
                writer.WriteStringValue(MetricName);
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

        ScheduledQueryRuleCondition IJsonModel<ScheduledQueryRuleCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledQueryRuleCondition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledQueryRuleCondition(document.RootElement, options);
        }

        internal static ScheduledQueryRuleCondition DeserializeScheduledQueryRuleCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string query = default;
            ScheduledQueryRuleTimeAggregationType? timeAggregation = default;
            string metricMeasureColumn = default;
            string resourceIdColumn = default;
            IList<MonitorDimension> dimensions = default;
            MonitorConditionOperator? @operator = default;
            double? threshold = default;
            ConditionFailingPeriods failingPeriods = default;
            string metricName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeAggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeAggregation = new ScheduledQueryRuleTimeAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricMeasureColumn"u8))
                {
                    metricMeasureColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceIdColumn"u8))
                {
                    resourceIdColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorDimension> array = new List<MonitorDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorDimension.DeserializeMonitorDimension(item, options));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = property.Value.GetString().ToMonitorConditionOperator();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("failingPeriods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failingPeriods = ConditionFailingPeriods.DeserializeConditionFailingPeriods(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScheduledQueryRuleCondition(
                query,
                timeAggregation,
                metricMeasureColumn,
                resourceIdColumn,
                dimensions ?? new ChangeTrackingList<MonitorDimension>(),
                @operator,
                threshold,
                failingPeriods,
                metricName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScheduledQueryRuleCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduledQueryRuleCondition)} does not support writing '{options.Format}' format.");
            }
        }

        ScheduledQueryRuleCondition IPersistableModel<ScheduledQueryRuleCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduledQueryRuleCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduledQueryRuleCondition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduledQueryRuleCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
