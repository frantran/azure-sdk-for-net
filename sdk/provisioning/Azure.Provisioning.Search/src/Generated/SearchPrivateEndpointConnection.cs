// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// SearchPrivateEndpointConnection.
/// </summary>
public partial class SearchPrivateEndpointConnection : Resource
{
    /// <summary>
    /// The name of the private endpoint connection to the Azure AI Search
    /// service with the specified resource group.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Describes the properties of an existing private endpoint connection to
    /// the Azure AI Search service.
    /// </summary>
    public BicepValue<SearchServicePrivateEndpointConnectionProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<SearchServicePrivateEndpointConnectionProperties> _properties;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SearchService.
    /// </summary>
    public SearchService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SearchService> _parent;

    /// <summary>
    /// Creates a new SearchPrivateEndpointConnection.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the SearchPrivateEndpointConnection
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SearchPrivateEndpointConnection.</param>
    public SearchPrivateEndpointConnection(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Search/searchServices/privateEndpointConnections", resourceVersion ?? "2023-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _properties = BicepValue<SearchServicePrivateEndpointConnectionProperties>.DefineProperty(this, "Properties", ["properties"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SearchService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SearchPrivateEndpointConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-06-01-Preview.
        /// </summary>
        public static readonly string V2024_06_01_Preview = "2024-06-01-Preview";

        /// <summary>
        /// 2024-03-01-Preview.
        /// </summary>
        public static readonly string V2024_03_01_Preview = "2024-03-01-Preview";

        /// <summary>
        /// 2023-11-01.
        /// </summary>
        public static readonly string V2023_11_01 = "2023-11-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2021-06-06-Preview.
        /// </summary>
        public static readonly string V2021_06_06_Preview = "2021-06-06-Preview";

        /// <summary>
        /// 2021-04-01-Preview.
        /// </summary>
        public static readonly string V2021_04_01_Preview = "2021-04-01-Preview";

        /// <summary>
        /// 2020-08-01-Preview.
        /// </summary>
        public static readonly string V2020_08_01_Preview = "2020-08-01-Preview";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";

        /// <summary>
        /// 2020-03-13.
        /// </summary>
        public static readonly string V2020_03_13 = "2020-03-13";

        /// <summary>
        /// 2019-10-01-Preview.
        /// </summary>
        public static readonly string V2019_10_01_Preview = "2019-10-01-Preview";

        /// <summary>
        /// 2015-08-19.
        /// </summary>
        public static readonly string V2015_08_19 = "2015-08-19";

        /// <summary>
        /// 2015-02-28.
        /// </summary>
        public static readonly string V2015_02_28 = "2015-02-28";

        /// <summary>
        /// 2014-07-31-Preview.
        /// </summary>
        public static readonly string V2014_07_31_Preview = "2014-07-31-Preview";
    }

    /// <summary>
    /// Creates a reference to an existing SearchPrivateEndpointConnection.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the SearchPrivateEndpointConnection
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SearchPrivateEndpointConnection.</param>
    /// <returns>The existing SearchPrivateEndpointConnection resource.</returns>
    public static SearchPrivateEndpointConnection FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
