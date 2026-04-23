using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGateway")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGateway : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpApiGateway
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#rest_api_id BedrockagentcoreGatewayTarget#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public string RestApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#stage BedrockagentcoreGatewayTarget#stage}.</summary>
        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}")]
        public string Stage
        {
            get;
            set;
        }

        private object? _apiGatewayToolConfiguration;

        /// <summary>api_gateway_tool_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#api_gateway_tool_configuration BedrockagentcoreGatewayTarget#api_gateway_tool_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiGatewayToolConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApiGatewayToolConfiguration
        {
            get => _apiGatewayToolConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _apiGatewayToolConfiguration = value;
            }
        }
    }
}
