using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInline")]
    public class BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInline : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInline
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#model_id BedrockagentFlow#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#template_type BedrockagentFlow#template_type}.</summary>
        [JsiiProperty(name: "templateType", typeJson: "{\"primitive\":\"string\"}")]
        public string TemplateType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#additional_model_request_fields BedrockagentFlow#additional_model_request_fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalModelRequestFields", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdditionalModelRequestFields
        {
            get;
            set;
        }

        private object? _inferenceConfiguration;

        /// <summary>inference_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#inference_configuration BedrockagentFlow#inference_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InferenceConfiguration
        {
            get => _inferenceConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inferenceConfiguration = value;
            }
        }

        private object? _templateConfiguration;

        /// <summary>template_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#template_configuration BedrockagentFlow#template_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TemplateConfiguration
        {
            get => _templateConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _templateConfiguration = value;
            }
        }
    }
}
