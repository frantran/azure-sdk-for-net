// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    public partial class UserRequestSchedule : IUtf8JsonSerializable, IJsonModel<UserRequestSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserRequestSchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UserRequestSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserRequestSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserRequestSchedule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("deadLine"u8);
            writer.WriteStringValue(DeadLine, "O");
            writer.WritePropertyName("timeZone"u8);
            writer.WriteStringValue(TimeZone);
            writer.WritePropertyName("deadlineType"u8);
            writer.WriteStringValue(DeadlineType.ToString());
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

        UserRequestSchedule IJsonModel<UserRequestSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserRequestSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserRequestSchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserRequestSchedule(document.RootElement, options);
        }

        internal static UserRequestSchedule DeserializeUserRequestSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset deadLine = default;
            string timeZone = default;
            ScheduledActionDeadlineType deadlineType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deadLine"u8))
                {
                    deadLine = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadlineType"u8))
                {
                    deadlineType = new ScheduledActionDeadlineType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UserRequestSchedule(deadLine, timeZone, deadlineType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserRequestSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserRequestSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserRequestSchedule)} does not support writing '{options.Format}' format.");
            }
        }

        UserRequestSchedule IPersistableModel<UserRequestSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserRequestSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserRequestSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserRequestSchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserRequestSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
