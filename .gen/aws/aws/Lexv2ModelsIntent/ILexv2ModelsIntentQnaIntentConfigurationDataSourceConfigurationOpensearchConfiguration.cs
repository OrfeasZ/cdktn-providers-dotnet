using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration")]
    public interface ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#domain_endpoint Lexv2ModelsIntent#domain_endpoint}.</summary>
        [JsiiProperty(name: "domainEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string DomainEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#index_name Lexv2ModelsIntent#index_name}.</summary>
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
        string IndexName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#exact_response Lexv2ModelsIntent#exact_response}.</summary>
        [JsiiProperty(name: "exactResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExactResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>exact_response_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#exact_response_fields Lexv2ModelsIntent#exact_response_fields}
        /// </remarks>
        [JsiiProperty(name: "exactResponseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExactResponseFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#include_fields Lexv2ModelsIntent#include_fields}.</summary>
        [JsiiProperty(name: "includeFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludeFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#domain_endpoint Lexv2ModelsIntent#domain_endpoint}.</summary>
            [JsiiProperty(name: "domainEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#index_name Lexv2ModelsIntent#index_name}.</summary>
            [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
            public string IndexName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#exact_response Lexv2ModelsIntent#exact_response}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exactResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExactResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>exact_response_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#exact_response_fields Lexv2ModelsIntent#exact_response_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exactResponseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExactResponseFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#include_fields Lexv2ModelsIntent#include_fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludeFields
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
