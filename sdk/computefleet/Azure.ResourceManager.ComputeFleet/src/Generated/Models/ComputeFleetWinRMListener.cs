// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Describes Protocol and thumbprint of Windows Remote Management listener. </summary>
    public partial class ComputeFleetWinRMListener
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

        /// <summary> Initializes a new instance of <see cref="ComputeFleetWinRMListener"/>. </summary>
        public ComputeFleetWinRMListener()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetWinRMListener"/>. </summary>
        /// <param name="protocol">
        /// Specifies the protocol of WinRM listener. Possible values are: **http,**
        /// **https.**
        /// </param>
        /// <param name="certificateUri">
        /// This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        /// key
        /// vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be the Base64 encoding of the following
        /// JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt;
        /// "data":"&lt;Base64-encoded-certificate&gt;",&lt;br&gt;  "dataType":"pfx",&lt;br&gt;
        /// "password":"&lt;pfx-file-password&gt;"&lt;br&gt;} &lt;br&gt; To install certificates on a virtual
        /// machine it is recommended to use the [Azure Key Vault virtual machine extension
        /// for
        /// Linux](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeFleetWinRMListener(ComputeFleetProtocolType? protocol, Uri certificateUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Protocol = protocol;
            CertificateUri = certificateUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Specifies the protocol of WinRM listener. Possible values are: **http,**
        /// **https.**
        /// </summary>
        public ComputeFleetProtocolType? Protocol { get; set; }
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        /// key
        /// vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be the Base64 encoding of the following
        /// JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt;
        /// "data":"&lt;Base64-encoded-certificate&gt;",&lt;br&gt;  "dataType":"pfx",&lt;br&gt;
        /// "password":"&lt;pfx-file-password&gt;"&lt;br&gt;} &lt;br&gt; To install certificates on a virtual
        /// machine it is recommended to use the [Azure Key Vault virtual machine extension
        /// for
        /// Linux](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        public Uri CertificateUri { get; set; }
    }
}
