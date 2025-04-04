// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class DataFeedDimension : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dimensionName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("dimensionDisplayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
        }

        internal static DataFeedDimension DeserializeDataFeedDimension(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dimensionName = default;
            string dimensionDisplayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionDisplayName"u8))
                {
                    dimensionDisplayName = property.Value.GetString();
                    continue;
                }
            }
            return new DataFeedDimension(dimensionName, dimensionDisplayName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataFeedDimension FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDataFeedDimension(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
