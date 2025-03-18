﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.InputTransformation;
using Azure.Generator.Primitives;
using Azure.Generator.Providers;
using Azure.Generator.Providers.Abstraction;
using Microsoft.TypeSpec.Generator.ClientModel;
using Microsoft.TypeSpec.Generator.ClientModel.Providers;
using Microsoft.TypeSpec.Generator.Expressions;
using Microsoft.TypeSpec.Generator.Input;
using Microsoft.TypeSpec.Generator.Primitives;
using Microsoft.TypeSpec.Generator.Providers;
using Microsoft.TypeSpec.Generator.Snippets;
using Microsoft.TypeSpec.Generator.Statements;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Generator
{
    /// <inheritdoc/>
    public class AzureTypeFactory : ScmTypeFactory
    {
        /// <inheritdoc/>
        public override IClientResponseApi ClientResponseApi => AzureClientResponseProvider.Instance;

        /// <inheritdoc/>
        public override IHttpResponseApi HttpResponseApi => AzureResponseProvider.Instance;

        /// <inheritdoc/>
        public override IClientPipelineApi ClientPipelineApi => HttpPipelineProvider.Instance;

        /// <inheritdoc/>
        public override IHttpMessageApi HttpMessageApi => HttpMessageProvider.Instance;

        /// <inheritdoc/>
        public override IExpressionApi<HttpRequestApi> HttpRequestApi => HttpRequestProvider.Instance;

        /// <inheritdoc/>
        public override IStatusCodeClassifierApi StatusCodeClassifierApi => StatusCodeClassifierProvider.Instance;

        /// <inheritdoc/>
        public override IRequestContentApi RequestContentApi => RequestContentProvider.Instance;

        /// <inheritdoc/>
        public override IHttpRequestOptionsApi HttpRequestOptionsApi => HttpRequestOptionsProvider.Instance;

        /// <inheritdoc/>
        protected override CSharpType? CreateCSharpTypeCore(InputType inputType)
        {
            if (inputType is InputPrimitiveType inputPrimitiveType)
            {
                var result = CreateKnownPrimitiveType(inputPrimitiveType);
                if (result != null)
                {
                    return result;
                }
            }
            return base.CreateCSharpTypeCore(inputType);
        }

        private CSharpType? CreateKnownPrimitiveType(InputPrimitiveType inputType)
        {
            InputPrimitiveType? primitiveType = inputType;
            while (primitiveType != null)
            {
                if (KnownAzureTypes.TryGetPrimitiveType(primitiveType.CrossLanguageDefinitionId, out var knownType))
                {
                    return knownType;
                }

                primitiveType = primitiveType.BaseType;
            }

            return null;
        }

        /// <inheritdoc/>
#pragma warning disable AZC0014 // Avoid using banned types in public API
        public override ValueExpression DeserializeJsonValue(Type valueType, ScopedApi<JsonElement> element, SerializationFormat format)
#pragma warning restore AZC0014 // Avoid using banned types in public API
        {
            var expression = DeserializeJsonValueCore(valueType, element, format);
            return expression ?? base.DeserializeJsonValue(valueType, element, format);
        }

        private ValueExpression? DeserializeJsonValueCore(
            Type valueType,
            ScopedApi<JsonElement> element,
            SerializationFormat format)
        {
            return KnownAzureTypes.TryGetJsonDeserializationExpression(valueType, out var deserializationExpression) ?
                deserializationExpression(new CSharpType(valueType), element, format) :
                null;
        }

        /// <inheritdoc/>
        public override MethodBodyStatement SerializeJsonValue(Type valueType, ValueExpression value, ScopedApi<Utf8JsonWriter> utf8JsonWriter, ScopedApi<ModelReaderWriterOptions> mrwOptionsParameter, SerializationFormat serializationFormat)
        {
            var statement = SerializeValueTypeCore(serializationFormat, value, valueType, utf8JsonWriter, mrwOptionsParameter);
            return statement ?? base.SerializeJsonValue(valueType, value, utf8JsonWriter, mrwOptionsParameter, serializationFormat);
        }

        private MethodBodyStatement? SerializeValueTypeCore(SerializationFormat serializationFormat, ValueExpression value, Type valueType, ScopedApi<Utf8JsonWriter> utf8JsonWriter, ScopedApi<ModelReaderWriterOptions> mrwOptionsParameter)
        {
            return KnownAzureTypes.TryGetJsonSerializationExpression(valueType, out var serializationExpression) ?
                serializationExpression(value, utf8JsonWriter, mrwOptionsParameter, serializationFormat) :
                null;
        }

        /// <inheritdoc/>
        protected override ClientProvider? CreateClientCore(InputClient inputClient)
        {
            if (!AzureClientGenerator.Instance.IsAzureArm.Value)
            {
                return base.CreateClientCore(inputClient);
            }

            var transformedClient = InputClientTransformer.TransformInputClient(inputClient);
            return transformedClient is null ? null : base.CreateClientCore(transformedClient);
        }

        /// <inheritdoc/>
        public override NewProjectScaffolding CreateNewProjectScaffolding()
        {
            return new NewAzureProjectScaffolding();
        }
    }
}
