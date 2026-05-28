using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreGateway")]
    public class BedrockagentcoreHarnessToolConfigAgentcoreGateway : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreGateway
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#gateway_arn BedrockagentcoreHarness#gateway_arn}.</summary>
        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public string GatewayArn
        {
            get;
            set;
        }

        private object? _outboundAuth;

        /// <summary>outbound_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#outbound_auth BedrockagentcoreHarness#outbound_auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outboundAuth", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreGatewayOutboundAuth\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OutboundAuth
        {
            get => _outboundAuth;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreGatewayOutboundAuth[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreGatewayOutboundAuth).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _outboundAuth = value;
            }
        }
    }
}
