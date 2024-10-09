// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class OracleDBServerProperties : IUtf8JsonSerializable, IJsonModel<OracleDBServerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OracleDBServerProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OracleDBServerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleDBServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OracleDBServerProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Ocid))
            {
                writer.WritePropertyName("ocid"u8);
                writer.WriteStringValue(Ocid);
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(CompartmentId))
            {
                writer.WritePropertyName("compartmentId"u8);
                writer.WriteStringValue(CompartmentId);
            }
            if (options.Format != "W" && Optional.IsDefined(ExadataInfrastructureId))
            {
                writer.WritePropertyName("exadataInfrastructureId"u8);
                writer.WriteStringValue(ExadataInfrastructureId);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuCoreCount))
            {
                writer.WritePropertyName("cpuCoreCount"u8);
                writer.WriteNumberValue(CpuCoreCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DBServerPatchingDetails))
            {
                writer.WritePropertyName("dbServerPatchingDetails"u8);
                writer.WriteObjectValue(DBServerPatchingDetails, options);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxMemoryInGbs))
            {
                writer.WritePropertyName("maxMemoryInGbs"u8);
                writer.WriteNumberValue(MaxMemoryInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DBNodeStorageSizeInGbs))
            {
                writer.WritePropertyName("dbNodeStorageSizeInGbs"u8);
                writer.WriteNumberValue(DBNodeStorageSizeInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VmClusterIds))
            {
                writer.WritePropertyName("vmClusterIds"u8);
                writer.WriteStartArray();
                foreach (var item in VmClusterIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DBNodeIds))
            {
                writer.WritePropertyName("dbNodeIds"u8);
                writer.WriteStartArray();
                foreach (var item in DBNodeIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LifecycleDetails))
            {
                writer.WritePropertyName("lifecycleDetails"u8);
                writer.WriteStringValue(LifecycleDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(LifecycleState))
            {
                writer.WritePropertyName("lifecycleState"u8);
                writer.WriteStringValue(LifecycleState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MaxCpuCount))
            {
                writer.WritePropertyName("maxCpuCount"u8);
                writer.WriteNumberValue(MaxCpuCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AutonomousVmClusterIds))
            {
                writer.WritePropertyName("autonomousVmClusterIds"u8);
                writer.WriteStartArray();
                foreach (var item in AutonomousVmClusterIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AutonomousVirtualMachineIds))
            {
                writer.WritePropertyName("autonomousVirtualMachineIds"u8);
                writer.WriteStartArray();
                foreach (var item in AutonomousVirtualMachineIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(MaxDBNodeStorageInGbs))
            {
                writer.WritePropertyName("maxDbNodeStorageInGbs"u8);
                writer.WriteNumberValue(MaxDBNodeStorageInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemorySizeInGbs))
            {
                writer.WritePropertyName("memorySizeInGbs"u8);
                writer.WriteNumberValue(MemorySizeInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Shape))
            {
                writer.WritePropertyName("shape"u8);
                writer.WriteStringValue(Shape);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        OracleDBServerProperties IJsonModel<OracleDBServerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleDBServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OracleDBServerProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOracleDBServerProperties(document.RootElement, options);
        }

        internal static OracleDBServerProperties DeserializeOracleDBServerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier ocid = default;
            string displayName = default;
            ResourceIdentifier compartmentId = default;
            ResourceIdentifier exadataInfrastructureId = default;
            int? cpuCoreCount = default;
            DBServerPatchingDetails dbServerPatchingDetails = default;
            int? maxMemoryInGbs = default;
            int? dbNodeStorageSizeInGbs = default;
            IReadOnlyList<ResourceIdentifier> vmClusterIds = default;
            IReadOnlyList<ResourceIdentifier> dbNodeIds = default;
            string lifecycleDetails = default;
            DBServerProvisioningState? lifecycleState = default;
            int? maxCpuCount = default;
            IReadOnlyList<ResourceIdentifier> autonomousVmClusterIds = default;
            IReadOnlyList<ResourceIdentifier> autonomousVirtualMachineIds = default;
            int? maxDBNodeStorageInGbs = default;
            int? memorySizeInGbs = default;
            string shape = default;
            DateTimeOffset? timeCreated = default;
            OracleDatabaseResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ocid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ocid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("compartmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compartmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exadataInfrastructureId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exadataInfrastructureId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cpuCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCoreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dbServerPatchingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbServerPatchingDetails = DBServerPatchingDetails.DeserializeDBServerPatchingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("maxMemoryInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxMemoryInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dbNodeStorageSizeInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbNodeStorageSizeInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vmClusterIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    vmClusterIds = array;
                    continue;
                }
                if (property.NameEquals("dbNodeIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    dbNodeIds = array;
                    continue;
                }
                if (property.NameEquals("lifecycleDetails"u8))
                {
                    lifecycleDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lifecycleState = new DBServerProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxCpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autonomousVmClusterIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    autonomousVmClusterIds = array;
                    continue;
                }
                if (property.NameEquals("autonomousVirtualMachineIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    autonomousVirtualMachineIds = array;
                    continue;
                }
                if (property.NameEquals("maxDbNodeStorageInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDBNodeStorageInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memorySizeInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memorySizeInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("shape"u8))
                {
                    shape = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new OracleDatabaseResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OracleDBServerProperties(
                ocid,
                displayName,
                compartmentId,
                exadataInfrastructureId,
                cpuCoreCount,
                dbServerPatchingDetails,
                maxMemoryInGbs,
                dbNodeStorageSizeInGbs,
                vmClusterIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                dbNodeIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                lifecycleDetails,
                lifecycleState,
                maxCpuCount,
                autonomousVmClusterIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                autonomousVirtualMachineIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                maxDBNodeStorageInGbs,
                memorySizeInGbs,
                shape,
                timeCreated,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OracleDBServerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleDBServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OracleDBServerProperties)} does not support writing '{options.Format}' format.");
            }
        }

        OracleDBServerProperties IPersistableModel<OracleDBServerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleDBServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOracleDBServerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OracleDBServerProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OracleDBServerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
