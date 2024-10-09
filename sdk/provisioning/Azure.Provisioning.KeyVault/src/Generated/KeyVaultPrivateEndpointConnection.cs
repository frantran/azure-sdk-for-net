// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// KeyVaultPrivateEndpointConnection.
/// </summary>
public partial class KeyVaultPrivateEndpointConnection : Resource
{
    /// <summary>
    /// Name of the private endpoint connection associated with the key vault.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Approval state of the private link connection.
    /// </summary>
    public BicepValue<KeyVaultPrivateLinkServiceConnectionState> ConnectionState { get => _connectionState; set => _connectionState.Assign(value); }
    private readonly BicepValue<KeyVaultPrivateLinkServiceConnectionState> _connectionState;

    /// <summary>
    /// Modified whenever there is a change in the state of private endpoint
    /// connection.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; set => _eTag.Assign(value); }
    private readonly BicepValue<ETag> _eTag;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Azure location of the key vault resource.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId { get => _privateEndpointId; }
    private readonly BicepValue<ResourceIdentifier> _privateEndpointId;

    /// <summary>
    /// Provisioning state of the private endpoint connection.
    /// </summary>
    public BicepValue<KeyVaultPrivateEndpointConnectionProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<KeyVaultPrivateEndpointConnectionProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Tags assigned to the key vault resource.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Gets or sets a reference to the parent KeyVaultService.
    /// </summary>
    public KeyVaultService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<KeyVaultService> _parent;

    /// <summary>
    /// Creates a new KeyVaultPrivateEndpointConnection.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the KeyVaultPrivateEndpointConnection
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KeyVaultPrivateEndpointConnection.</param>
    public KeyVaultPrivateEndpointConnection(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.KeyVault/vaults/privateEndpointConnections", resourceVersion ?? "2023-07-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _connectionState = BicepValue<KeyVaultPrivateLinkServiceConnectionState>.DefineProperty(this, "ConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["etag"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["properties", "privateEndpoint", "id"], isOutput: true);
        _provisioningState = BicepValue<KeyVaultPrivateEndpointConnectionProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"], isOutput: true);
        _parent = ResourceReference<KeyVaultService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported KeyVaultPrivateEndpointConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01-preview.
        /// </summary>
        public static readonly string V2024_04_01_preview = "2024-04-01-preview";

        /// <summary>
        /// 2023-08-01-PREVIEW.
        /// </summary>
        public static readonly string V2023_08_01_PREVIEW = "2023-08-01-PREVIEW";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";

        /// <summary>
        /// 2018-02-14.
        /// </summary>
        public static readonly string V2018_02_14 = "2018-02-14";

        /// <summary>
        /// 2016-10-01.
        /// </summary>
        public static readonly string V2016_10_01 = "2016-10-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing KeyVaultPrivateEndpointConnection.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the KeyVaultPrivateEndpointConnection
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KeyVaultPrivateEndpointConnection.</param>
    /// <returns>The existing KeyVaultPrivateEndpointConnection resource.</returns>
    public static KeyVaultPrivateEndpointConnection FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
