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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlServerVersionCapability : IUtf8JsonSerializable, IJsonModel<SqlServerVersionCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerVersionCapability>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlServerVersionCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerVersionCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerVersionCapability)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedEditions))
            {
                writer.WritePropertyName("supportedEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedEditions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedElasticPoolEditions))
            {
                writer.WritePropertyName("supportedElasticPoolEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedElasticPoolEditions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        SqlServerVersionCapability IJsonModel<SqlServerVersionCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerVersionCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerVersionCapability)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerVersionCapability(document.RootElement, options);
        }

        internal static SqlServerVersionCapability DeserializeSqlServerVersionCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IReadOnlyList<EditionCapability> supportedEditions = default;
            IReadOnlyList<ElasticPoolEditionCapability> supportedElasticPoolEditions = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EditionCapability> array = new List<EditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EditionCapability.DeserializeEditionCapability(item, options));
                    }
                    supportedEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedElasticPoolEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticPoolEditionCapability> array = new List<ElasticPoolEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticPoolEditionCapability.DeserializeElasticPoolEditionCapability(item, options));
                    }
                    supportedElasticPoolEditions = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlServerVersionCapability(
                name,
                supportedEditions ?? new ChangeTrackingList<EditionCapability>(),
                supportedElasticPoolEditions ?? new ChangeTrackingList<ElasticPoolEditionCapability>(),
                status,
                reason,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedEditions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedEditions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedEditions))
                {
                    if (SupportedEditions.Any())
                    {
                        builder.Append("  supportedEditions: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedEditions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedEditions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedElasticPoolEditions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedElasticPoolEditions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedElasticPoolEditions))
                {
                    if (SupportedElasticPoolEditions.Any())
                    {
                        builder.Append("  supportedElasticPoolEditions: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedElasticPoolEditions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedElasticPoolEditions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reason), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  reason: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Reason))
                {
                    builder.Append("  reason: ");
                    if (Reason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Reason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Reason}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SqlServerVersionCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerVersionCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerVersionCapability)} does not support writing '{options.Format}' format.");
            }
        }

        SqlServerVersionCapability IPersistableModel<SqlServerVersionCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerVersionCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerVersionCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerVersionCapability)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerVersionCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
