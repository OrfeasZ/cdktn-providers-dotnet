using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfiguration")]
    public class BedrockagentcoreGatewayProtocolConfiguration : aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfiguration
    {
        private object? _mcp;

        /// <summary>mcp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#mcp BedrockagentcoreGateway#mcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mcp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Mcp
        {
            get => _mcp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcp[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcp).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mcp = value;
            }
        }
    }
}
