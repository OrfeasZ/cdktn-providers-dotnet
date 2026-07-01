using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration")]
    public class BedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration : aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcpStreamingConfiguration
    {
        private object? _enableResponseStreaming;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/bedrockagentcore_gateway#enable_response_streaming BedrockagentcoreGateway#enable_response_streaming}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableResponseStreaming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableResponseStreaming
        {
            get => _enableResponseStreaming;
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
                _enableResponseStreaming = value;
            }
        }
    }
}
