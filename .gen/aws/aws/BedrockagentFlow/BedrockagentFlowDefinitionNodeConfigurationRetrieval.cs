using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationRetrieval")]
    public class BedrockagentFlowDefinitionNodeConfigurationRetrieval : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationRetrieval
    {
        private object? _serviceConfiguration;

        /// <summary>service_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#service_configuration BedrockagentFlow#service_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServiceConfiguration
        {
            get => _serviceConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serviceConfiguration = value;
            }
        }
    }
}
