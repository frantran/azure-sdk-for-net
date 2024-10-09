// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> The query parameters to use for vector search when a base 64 encoded binary of an image that needs to be vectorized is provided. </summary>
    public partial class VectorizableImageBinaryQuery : VectorQuery
    {
        /// <summary> Initializes a new instance of <see cref="VectorizableImageBinaryQuery"/>. </summary>
        public VectorizableImageBinaryQuery()
        {
            Kind = VectorQueryKind.ImageBinary;
        }

        /// <summary> Initializes a new instance of <see cref="VectorizableImageBinaryQuery"/>. </summary>
        /// <param name="kind"> The kind of vector query being performed. </param>
        /// <param name="kNearestNeighborsCount"> Number of nearest neighbors to return as top hits. </param>
        /// <param name="fieldsRaw"> Vector Fields of type Collection(Edm.Single) to be included in the vector searched. </param>
        /// <param name="exhaustive"> When true, triggers an exhaustive k-nearest neighbor search across all vectors within the vector index. Useful for scenarios where exact matches are critical, such as determining ground truth values. </param>
        /// <param name="oversampling"> Oversampling factor. Minimum value is 1. It overrides the 'defaultOversampling' parameter configured in the index definition. It can be set only when 'rerankWithOriginalVectors' is true. This parameter is only permitted when a compression method is used on the underlying vector field. </param>
        /// <param name="weight"> Relative weight of the vector query when compared to other vector query and/or the text query within the same search request. This value is used when combining the results of multiple ranking lists produced by the different vector queries and/or the results retrieved through the text query. The higher the weight, the higher the documents that matched that query will be in the final ranking. Default is 1.0 and the value needs to be a positive number larger than zero. </param>
        /// <param name="threshold">
        /// The threshold used for vector queries. Note this can only be set if all 'fields' use the same similarity metric.
        /// Please note <see cref="VectorThreshold"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchScoreThreshold"/> and <see cref="VectorSimilarityThreshold"/>.
        /// </param>
        /// <param name="filterOverride"> The OData filter expression to apply to this specific vector query. If no filter expression is defined at the vector level, the expression defined in the top level filter parameter is used instead. </param>
        /// <param name="base64Image"> The base 64 encoded binary of an image to be vectorized to perform a vector search query. </param>
        internal VectorizableImageBinaryQuery(VectorQueryKind kind, int? kNearestNeighborsCount, string fieldsRaw, bool? exhaustive, double? oversampling, float? weight, VectorThreshold threshold, string filterOverride, string base64Image) : base(kind, kNearestNeighborsCount, fieldsRaw, exhaustive, oversampling, weight, threshold, filterOverride)
        {
            Base64Image = base64Image;
            Kind = kind;
        }

        /// <summary> The base 64 encoded binary of an image to be vectorized to perform a vector search query. </summary>
        public string Base64Image { get; set; }
    }
}
