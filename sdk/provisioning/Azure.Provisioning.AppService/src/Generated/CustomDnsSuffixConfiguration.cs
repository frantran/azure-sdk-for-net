// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// CustomDnsSuffixConfiguration.
/// </summary>
public partial class CustomDnsSuffixConfiguration : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The URL referencing the Azure Key Vault certificate secret that should
    /// be used as the default SSL/TLS certificate for sites with the custom
    /// domain suffix.
    /// </summary>
    public BicepValue<Uri> CertificateUri { get => _certificateUri; set => _certificateUri.Assign(value); }
    private readonly BicepValue<Uri> _certificateUri;

    /// <summary>
    /// The default custom domain suffix to use for all sites deployed on the
    /// ASE.
    /// </summary>
    public BicepValue<string> DnsSuffix { get => _dnsSuffix; set => _dnsSuffix.Assign(value); }
    private readonly BicepValue<string> _dnsSuffix;

    /// <summary>
    /// The user-assigned identity to use for resolving the key vault
    /// certificate reference. If not specified, the system-assigned ASE
    /// identity will be used if available.
    /// </summary>
    public BicepValue<string> KeyVaultReferenceIdentity { get => _keyVaultReferenceIdentity; set => _keyVaultReferenceIdentity.Assign(value); }
    private readonly BicepValue<string> _keyVaultReferenceIdentity;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the provisioning details.
    /// </summary>
    public BicepValue<string> ProvisioningDetails { get => _provisioningDetails; }
    private readonly BicepValue<string> _provisioningDetails;

    /// <summary>
    /// Gets the provisioning state.
    /// </summary>
    public BicepValue<CustomDnsSuffixProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<CustomDnsSuffixProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent AppServiceEnvironment.
    /// </summary>
    public AppServiceEnvironment? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<AppServiceEnvironment> _parent;

    /// <summary>
    /// Creates a new CustomDnsSuffixConfiguration.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the CustomDnsSuffixConfiguration
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CustomDnsSuffixConfiguration.</param>
    public CustomDnsSuffixConfiguration(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Web/hostingEnvironments/configurations", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _certificateUri = BicepValue<Uri>.DefineProperty(this, "CertificateUri", ["properties", "certificateUrl"]);
        _dnsSuffix = BicepValue<string>.DefineProperty(this, "DnsSuffix", ["properties", "dnsSuffix"]);
        _keyVaultReferenceIdentity = BicepValue<string>.DefineProperty(this, "KeyVaultReferenceIdentity", ["properties", "keyVaultReferenceIdentity"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningDetails = BicepValue<string>.DefineProperty(this, "ProvisioningDetails", ["properties", "provisioningDetails"], isOutput: true);
        _provisioningState = BicepValue<CustomDnsSuffixProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<AppServiceEnvironment>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported CustomDnsSuffixConfiguration resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2019-02-01.
        /// </summary>
        public static readonly string V2019_02_01 = "2019-02-01";

        /// <summary>
        /// 2019-01-01.
        /// </summary>
        public static readonly string V2019_01_01 = "2019-01-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-08-01.
        /// </summary>
        public static readonly string V2018_08_01 = "2018-08-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-07-01.
        /// </summary>
        public static readonly string V2015_07_01 = "2015-07-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";

        /// <summary>
        /// 2015-05-01.
        /// </summary>
        public static readonly string V2015_05_01 = "2015-05-01";

        /// <summary>
        /// 2015-04-01.
        /// </summary>
        public static readonly string V2015_04_01 = "2015-04-01";

        /// <summary>
        /// 2015-02-01.
        /// </summary>
        public static readonly string V2015_02_01 = "2015-02-01";

        /// <summary>
        /// 2014-11-01.
        /// </summary>
        public static readonly string V2014_11_01 = "2014-11-01";

        /// <summary>
        /// 2014-06-01.
        /// </summary>
        public static readonly string V2014_06_01 = "2014-06-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing CustomDnsSuffixConfiguration.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the CustomDnsSuffixConfiguration
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CustomDnsSuffixConfiguration.</param>
    /// <returns>The existing CustomDnsSuffixConfiguration resource.</returns>
    public static CustomDnsSuffixConfiguration FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
