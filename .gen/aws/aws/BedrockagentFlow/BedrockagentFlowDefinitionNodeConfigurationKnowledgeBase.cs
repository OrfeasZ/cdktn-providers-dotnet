using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBase")]
    public class BedrockagentFlowDefinitionNodeConfigurationKnowledgeBase : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#knowledge_base_id BedrockagentFlow#knowledge_base_id}.</summary>
        [JsiiProperty(name: "knowledgeBaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string KnowledgeBaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#model_id BedrockagentFlow#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelId
        {
            get;
            set;
        }

        private object? _guardrailConfiguration;

        /// <summary>guardrail_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#guardrail_configuration BedrockagentFlow#guardrail_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guardrailConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GuardrailConfiguration
        {
            get => _guardrailConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _guardrailConfiguration = value;
            }
        }

        private object? _inferenceConfiguration;

        /// <summary>inference_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#inference_configuration BedrockagentFlow#inference_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inferenceConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#number_of_results BedrockagentFlow#number_of_results}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfResults", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfResults
        {
            get;
            set;
        }
    }
}
