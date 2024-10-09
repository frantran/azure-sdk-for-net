// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkDeviceInterfaceData : IUtf8JsonSerializable, IJsonModel<NetworkDeviceInterfaceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkDeviceInterfaceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkDeviceInterfaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceInterfaceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkDeviceInterfaceData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (options.Format != "W" && Optional.IsDefined(PhysicalIdentifier))
            {
                writer.WritePropertyName("physicalIdentifier"u8);
                writer.WriteStringValue(PhysicalIdentifier);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectedTo))
            {
                writer.WritePropertyName("connectedTo"u8);
                writer.WriteStringValue(ConnectedTo);
            }
            if (options.Format != "W" && Optional.IsDefined(InterfaceType))
            {
                writer.WritePropertyName("interfaceType"u8);
                writer.WriteStringValue(InterfaceType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IPv4Address))
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStringValue(IPv4Address.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IPv6Address))
            {
                writer.WritePropertyName("ipv6Address"u8);
                writer.WriteStringValue(IPv6Address);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AdministrativeState))
            {
                writer.WritePropertyName("administrativeState"u8);
                writer.WriteStringValue(AdministrativeState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        NetworkDeviceInterfaceData IJsonModel<NetworkDeviceInterfaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceInterfaceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkDeviceInterfaceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkDeviceInterfaceData(document.RootElement, options);
        }

        internal static NetworkDeviceInterfaceData DeserializeNetworkDeviceInterfaceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string annotation = default;
            string physicalIdentifier = default;
            string connectedTo = default;
            NetworkDeviceInterfaceType? interfaceType = default;
            IPAddress ipv4Address = default;
            string ipv6Address = default;
            NetworkFabricProvisioningState? provisioningState = default;
            NetworkFabricAdministrativeState? administrativeState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("physicalIdentifier"u8))
                        {
                            physicalIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectedTo"u8))
                        {
                            connectedTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interfaceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interfaceType = new NetworkDeviceInterfaceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipv4Address"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipv4Address = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipv6Address"u8))
                        {
                            ipv6Address = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkDeviceInterfaceData(
                id,
                name,
                type,
                systemData,
                annotation,
                physicalIdentifier,
                connectedTo,
                interfaceType,
                ipv4Address,
                ipv6Address,
                provisioningState,
                administrativeState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkDeviceInterfaceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceInterfaceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkDeviceInterfaceData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkDeviceInterfaceData IPersistableModel<NetworkDeviceInterfaceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkDeviceInterfaceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkDeviceInterfaceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkDeviceInterfaceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkDeviceInterfaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
