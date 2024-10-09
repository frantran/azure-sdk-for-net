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
    public partial class ClassificationTrainingSettings : IUtf8JsonSerializable, IJsonModel<ClassificationTrainingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClassificationTrainingSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClassificationTrainingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassificationTrainingSettings)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(AllowedTrainingAlgorithms))
            {
                if (AllowedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("allowedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in AllowedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedTrainingAlgorithms");
                }
            }
            if (Optional.IsCollectionDefined(BlockedTrainingAlgorithms))
            {
                if (BlockedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("blockedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in BlockedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("blockedTrainingAlgorithms");
                }
            }
        }

        ClassificationTrainingSettings IJsonModel<ClassificationTrainingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassificationTrainingSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClassificationTrainingSettings(document.RootElement, options);
        }

        internal static ClassificationTrainingSettings DeserializeClassificationTrainingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ClassificationModel> allowedTrainingAlgorithms = default;
            IList<ClassificationModel> blockedTrainingAlgorithms = default;
            bool? enableOnnxCompatibleModels = default;
            MachineLearningStackEnsembleSettings stackEnsembleSettings = default;
            bool? enableStackEnsemble = default;
            bool? enableVoteEnsemble = default;
            TimeSpan? ensembleModelDownloadTimeout = default;
            bool? enableModelExplainability = default;
            bool? enableDnnTraining = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        allowedTrainingAlgorithms = null;
                        continue;
                    }
                    List<ClassificationModel> array = new List<ClassificationModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ClassificationModel(item.GetString()));
                    }
                    allowedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("blockedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blockedTrainingAlgorithms = null;
                        continue;
                    }
                    List<ClassificationModel> array = new List<ClassificationModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ClassificationModel(item.GetString()));
                    }
                    blockedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("enableOnnxCompatibleModels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableOnnxCompatibleModels = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stackEnsembleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stackEnsembleSettings = null;
                        continue;
                    }
                    stackEnsembleSettings = MachineLearningStackEnsembleSettings.DeserializeMachineLearningStackEnsembleSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enableStackEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableStackEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableVoteEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableVoteEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ensembleModelDownloadTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ensembleModelDownloadTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("enableModelExplainability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableModelExplainability = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableDnnTraining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnnTraining = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClassificationTrainingSettings(
                enableOnnxCompatibleModels,
                stackEnsembleSettings,
                enableStackEnsemble,
                enableVoteEnsemble,
                ensembleModelDownloadTimeout,
                enableModelExplainability,
                enableDnnTraining,
                serializedAdditionalRawData,
                allowedTrainingAlgorithms ?? new ChangeTrackingList<ClassificationModel>(),
                blockedTrainingAlgorithms ?? new ChangeTrackingList<ClassificationModel>());
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedTrainingAlgorithms), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowedTrainingAlgorithms: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AllowedTrainingAlgorithms))
                {
                    if (AllowedTrainingAlgorithms.Any())
                    {
                        builder.Append("  allowedTrainingAlgorithms: ");
                        builder.AppendLine("[");
                        foreach (var item in AllowedTrainingAlgorithms)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlockedTrainingAlgorithms), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  blockedTrainingAlgorithms: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BlockedTrainingAlgorithms))
                {
                    if (BlockedTrainingAlgorithms.Any())
                    {
                        builder.Append("  blockedTrainingAlgorithms: ");
                        builder.AppendLine("[");
                        foreach (var item in BlockedTrainingAlgorithms)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsOnnxCompatibleModelsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableOnnxCompatibleModels: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsOnnxCompatibleModelsEnabled))
                {
                    builder.Append("  enableOnnxCompatibleModels: ");
                    var boolValue = IsOnnxCompatibleModelsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StackEnsembleSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  stackEnsembleSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StackEnsembleSettings))
                {
                    builder.Append("  stackEnsembleSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, StackEnsembleSettings, options, 2, false, "  stackEnsembleSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStackEnsembleEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableStackEnsemble: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStackEnsembleEnabled))
                {
                    builder.Append("  enableStackEnsemble: ");
                    var boolValue = IsStackEnsembleEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsVoteEnsembleEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableVoteEnsemble: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsVoteEnsembleEnabled))
                {
                    builder.Append("  enableVoteEnsemble: ");
                    var boolValue = IsVoteEnsembleEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnsembleModelDownloadTimeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ensembleModelDownloadTimeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnsembleModelDownloadTimeout))
                {
                    builder.Append("  ensembleModelDownloadTimeout: ");
                    var formattedTimeSpan = TypeFormatters.ToString(EnsembleModelDownloadTimeout.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsModelExplainabilityEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableModelExplainability: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsModelExplainabilityEnabled))
                {
                    builder.Append("  enableModelExplainability: ");
                    var boolValue = IsModelExplainabilityEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDnnTrainingEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableDnnTraining: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDnnTrainingEnabled))
                {
                    builder.Append("  enableDnnTraining: ");
                    var boolValue = IsDnnTrainingEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClassificationTrainingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClassificationTrainingSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ClassificationTrainingSettings IPersistableModel<ClassificationTrainingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClassificationTrainingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClassificationTrainingSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClassificationTrainingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
