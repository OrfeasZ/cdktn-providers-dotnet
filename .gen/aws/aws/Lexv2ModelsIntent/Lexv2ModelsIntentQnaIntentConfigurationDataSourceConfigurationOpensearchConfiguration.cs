using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration")]
    public class Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration : aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#domain_endpoint Lexv2ModelsIntent#domain_endpoint}.</summary>
        [JsiiProperty(name: "domainEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#index_name Lexv2ModelsIntent#index_name}.</summary>
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
        public string IndexName
        {
            get;
            set;
        }

        private object? _exactResponse;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#exact_response Lexv2ModelsIntent#exact_response}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exactResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExactResponse
        {
            get => _exactResponse;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exactResponse = value;
            }
        }

        private object? _exactResponseFields;

        /// <summary>exact_response_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#exact_response_fields Lexv2ModelsIntent#exact_response_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exactResponseFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExactResponseFields
        {
            get => _exactResponseFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfigurationExactResponseFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exactResponseFields = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lexv2models_intent#include_fields Lexv2ModelsIntent#include_fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludeFields
        {
            get;
            set;
        }
    }
}
