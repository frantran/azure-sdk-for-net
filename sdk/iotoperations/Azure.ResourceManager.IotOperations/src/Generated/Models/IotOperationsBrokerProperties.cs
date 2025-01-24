// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> Broker Resource properties. </summary>
    public partial class IotOperationsBrokerProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotOperationsBrokerProperties"/>. </summary>
        public IotOperationsBrokerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotOperationsBrokerProperties"/>. </summary>
        /// <param name="advanced"> Advanced settings of Broker. </param>
        /// <param name="cardinality"> The cardinality details of the broker. </param>
        /// <param name="diagnostics"> Spec defines the desired identities of Broker diagnostics settings. </param>
        /// <param name="diskBackedMessageBuffer"> Settings of Disk Backed Message Buffer. </param>
        /// <param name="generateResourceLimits"> This setting controls whether Kubernetes CPU resource limits are requested. Increasing the number of replicas or workers proportionally increases the amount of CPU resources requested. If this setting is enabled and there are insufficient CPU resources, an error will be emitted. </param>
        /// <param name="memoryProfile"> Memory profile of Broker. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotOperationsBrokerProperties(BrokerAdvancedSettings advanced, BrokerCardinality cardinality, BrokerDiagnostics diagnostics, DiskBackedMessageBuffer diskBackedMessageBuffer, GenerateResourceLimits generateResourceLimits, BrokerMemoryProfile? memoryProfile, IotOperationsProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Advanced = advanced;
            Cardinality = cardinality;
            Diagnostics = diagnostics;
            DiskBackedMessageBuffer = diskBackedMessageBuffer;
            GenerateResourceLimits = generateResourceLimits;
            MemoryProfile = memoryProfile;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Advanced settings of Broker. </summary>
        public BrokerAdvancedSettings Advanced { get; set; }
        /// <summary> The cardinality details of the broker. </summary>
        public BrokerCardinality Cardinality { get; set; }
        /// <summary> Spec defines the desired identities of Broker diagnostics settings. </summary>
        public BrokerDiagnostics Diagnostics { get; set; }
        /// <summary> Settings of Disk Backed Message Buffer. </summary>
        public DiskBackedMessageBuffer DiskBackedMessageBuffer { get; set; }
        /// <summary> This setting controls whether Kubernetes CPU resource limits are requested. Increasing the number of replicas or workers proportionally increases the amount of CPU resources requested. If this setting is enabled and there are insufficient CPU resources, an error will be emitted. </summary>
        internal GenerateResourceLimits GenerateResourceLimits { get; set; }
        /// <summary> The toggle to enable/disable cpu resource limits. </summary>
        public IotOperationsOperationalMode? GenerateResourceLimitsCpu
        {
            get => GenerateResourceLimits is null ? default : GenerateResourceLimits.Cpu;
            set
            {
                if (GenerateResourceLimits is null)
                    GenerateResourceLimits = new GenerateResourceLimits();
                GenerateResourceLimits.Cpu = value;
            }
        }

        /// <summary> Memory profile of Broker. </summary>
        public BrokerMemoryProfile? MemoryProfile { get; set; }
        /// <summary> The status of the last operation. </summary>
        public IotOperationsProvisioningState? ProvisioningState { get; }
    }
}
