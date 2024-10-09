// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Contains configuration options specific to the compression method used during indexing or querying.
    /// Please note <see cref="VectorSearchCompression"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BinaryQuantizationCompression"/> and <see cref="ScalarQuantizationCompression"/>.
    /// </summary>
    public abstract partial class VectorSearchCompression
    {
        /// <summary> Initializes a new instance of <see cref="VectorSearchCompression"/>. </summary>
        /// <param name="compressionName"> The name to associate with this particular configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="compressionName"/> is null. </exception>
        protected VectorSearchCompression(string compressionName)
        {
            Argument.AssertNotNull(compressionName, nameof(compressionName));

            CompressionName = compressionName;
        }

        /// <summary> Initializes a new instance of <see cref="VectorSearchCompression"/>. </summary>
        /// <param name="compressionName"> The name to associate with this particular configuration. </param>
        /// <param name="kind"> The name of the kind of compression method being configured for use with vector search. </param>
        /// <param name="rerankWithOriginalVectors"> If set to true, once the ordered set of results calculated using compressed vectors are obtained, they will be reranked again by recalculating the full-precision similarity scores. This will improve recall at the expense of latency. </param>
        /// <param name="defaultOversampling"> Default oversampling factor. Oversampling will internally request more documents (specified by this multiplier) in the initial search. This increases the set of results that will be reranked using recomputed similarity scores from full-precision vectors. Minimum value is 1, meaning no oversampling (1x). This parameter can only be set when rerankWithOriginalVectors is true. Higher values improve recall at the expense of latency. </param>
        /// <param name="truncationDimension"> The number of dimensions to truncate the vectors to. Truncating the vectors reduces the size of the vectors and the amount of data that needs to be transferred during search. This can save storage cost and improve search performance at the expense of recall. It should be only used for embeddings trained with Matryoshka Representation Learning (MRL) such as OpenAI text-embedding-3-large (small). The default value is null, which means no truncation. </param>
        internal VectorSearchCompression(string compressionName, VectorSearchCompressionKind kind, bool? rerankWithOriginalVectors, double? defaultOversampling, int? truncationDimension)
        {
            CompressionName = compressionName;
            Kind = kind;
            RerankWithOriginalVectors = rerankWithOriginalVectors;
            DefaultOversampling = defaultOversampling;
            TruncationDimension = truncationDimension;
        }
        /// <summary> The name of the kind of compression method being configured for use with vector search. </summary>
        internal VectorSearchCompressionKind Kind { get; set; }
        /// <summary> If set to true, once the ordered set of results calculated using compressed vectors are obtained, they will be reranked again by recalculating the full-precision similarity scores. This will improve recall at the expense of latency. </summary>
        public bool? RerankWithOriginalVectors { get; set; }
        /// <summary> Default oversampling factor. Oversampling will internally request more documents (specified by this multiplier) in the initial search. This increases the set of results that will be reranked using recomputed similarity scores from full-precision vectors. Minimum value is 1, meaning no oversampling (1x). This parameter can only be set when rerankWithOriginalVectors is true. Higher values improve recall at the expense of latency. </summary>
        public double? DefaultOversampling { get; set; }
        /// <summary> The number of dimensions to truncate the vectors to. Truncating the vectors reduces the size of the vectors and the amount of data that needs to be transferred during search. This can save storage cost and improve search performance at the expense of recall. It should be only used for embeddings trained with Matryoshka Representation Learning (MRL) such as OpenAI text-embedding-3-large (small). The default value is null, which means no truncation. </summary>
        public int? TruncationDimension { get; set; }
    }
}
