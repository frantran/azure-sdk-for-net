// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A class representing the AutoUpgradeProfile data model.
    /// The AutoUpgradeProfile resource.
    /// </summary>
    public partial class AutoUpgradeProfileData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AutoUpgradeProfileData"/>. </summary>
        public AutoUpgradeProfileData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutoUpgradeProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="provisioningState"> The provisioning state of the AutoUpgradeProfile resource. </param>
        /// <param name="updateStrategyId"> The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters which are members of the fleet. </param>
        /// <param name="channel"> Configures how auto-upgrade will be run. </param>
        /// <param name="nodeImageSelection"> The node image upgrade to be applied to the target clusters in auto upgrade. </param>
        /// <param name="disabled">
        /// If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        /// By default, this is set to False.
        /// </param>
        /// <param name="autoUpgradeProfileStatus"> The status of the auto upgrade profile. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoUpgradeProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? eTag, AutoUpgradeProfileProvisioningState? provisioningState, ResourceIdentifier updateStrategyId, ContainerServiceFleetUpgradeChannel? channel, AutoUpgradeNodeImageSelection nodeImageSelection, bool? disabled, AutoUpgradeProfileStatus autoUpgradeProfileStatus, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ETag = eTag;
            ProvisioningState = provisioningState;
            UpdateStrategyId = updateStrategyId;
            Channel = channel;
            NodeImageSelection = nodeImageSelection;
            Disabled = disabled;
            AutoUpgradeProfileStatus = autoUpgradeProfileStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </summary>
        public ETag? ETag { get; }
        /// <summary> The provisioning state of the AutoUpgradeProfile resource. </summary>
        public AutoUpgradeProfileProvisioningState? ProvisioningState { get; }
        /// <summary> The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters which are members of the fleet. </summary>
        public ResourceIdentifier UpdateStrategyId { get; set; }
        /// <summary> Configures how auto-upgrade will be run. </summary>
        public ContainerServiceFleetUpgradeChannel? Channel { get; set; }
        /// <summary> The node image upgrade to be applied to the target clusters in auto upgrade. </summary>
        internal AutoUpgradeNodeImageSelection NodeImageSelection { get; set; }
        /// <summary> The node image upgrade type. </summary>
        public AutoUpgradeNodeImageSelectionType? SelectionType
        {
            get => NodeImageSelection is null ? default(AutoUpgradeNodeImageSelectionType?) : NodeImageSelection.SelectionType;
            set
            {
                NodeImageSelection = value.HasValue ? new AutoUpgradeNodeImageSelection(value.Value) : null;
            }
        }

        /// <summary>
        /// If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        /// By default, this is set to False.
        /// </summary>
        public bool? Disabled { get; set; }
        /// <summary> The status of the auto upgrade profile. </summary>
        public AutoUpgradeProfileStatus AutoUpgradeProfileStatus { get; set; }
    }
}
