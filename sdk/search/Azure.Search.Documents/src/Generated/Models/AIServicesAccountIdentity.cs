// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The multi-region account of an Azure AI service resource that's attached to a skillset. </summary>
    public partial class AIServicesAccountIdentity : CognitiveServicesAccount
    {
        /// <summary> Initializes a new instance of <see cref="AIServicesAccountIdentity"/>. </summary>
        /// <param name="subdomainUrl"> The subdomain url for the corresponding AI Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subdomainUrl"/> is null. </exception>
        public AIServicesAccountIdentity(string subdomainUrl)
        {
            Argument.AssertNotNull(subdomainUrl, nameof(subdomainUrl));

            SubdomainUrl = subdomainUrl;
            ODataType = "#Microsoft.Azure.Search.AIServicesByIdentity";
        }

        /// <summary> Initializes a new instance of <see cref="AIServicesAccountIdentity"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of Azure AI service resource attached to a skillset. </param>
        /// <param name="description"> Description of the Azure AI service resource attached to a skillset. </param>
        /// <param name="identity">
        /// The user-assigned managed identity used for connections to AI Service. If not specified, the system-assigned managed identity is used. On updates to the skillset, if the identity is unspecified, the value remains unchanged. If set to "none", the value of this property is cleared.
        /// Please note <see cref="SearchIndexerDataIdentity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchIndexerDataNoneIdentity"/> and <see cref="SearchIndexerDataUserAssignedIdentity"/>.
        /// </param>
        /// <param name="subdomainUrl"> The subdomain url for the corresponding AI Service. </param>
        internal AIServicesAccountIdentity(string oDataType, string description, SearchIndexerDataIdentity identity, string subdomainUrl) : base(oDataType, description)
        {
            Identity = identity;
            SubdomainUrl = subdomainUrl;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.AIServicesByIdentity";
        }

        /// <summary>
        /// The user-assigned managed identity used for connections to AI Service. If not specified, the system-assigned managed identity is used. On updates to the skillset, if the identity is unspecified, the value remains unchanged. If set to "none", the value of this property is cleared.
        /// Please note <see cref="SearchIndexerDataIdentity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchIndexerDataNoneIdentity"/> and <see cref="SearchIndexerDataUserAssignedIdentity"/>.
        /// </summary>
        public SearchIndexerDataIdentity Identity { get; set; }
        /// <summary> The subdomain url for the corresponding AI Service. </summary>
        public string SubdomainUrl { get; set; }
    }
}
