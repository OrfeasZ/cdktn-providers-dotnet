using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfiguration")]
    public class BedrockagentcoreGatewayInterceptorConfiguration : aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#interception_points BedrockagentcoreGateway#interception_points}.</summary>
        [JsiiProperty(name: "interceptionPoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] InterceptionPoints
        {
            get;
            set;
        }

        private object? _inputConfiguration;

        /// <summary>input_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#input_configuration BedrockagentcoreGateway#input_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInputConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InputConfiguration
        {
            get => _inputConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInputConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInputConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputConfiguration = value;
            }
        }

        private object? _interceptor;

        /// <summary>interceptor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#interceptor BedrockagentcoreGateway#interceptor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interceptor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Interceptor
        {
            get => _interceptor;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInterceptor[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInterceptor).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _interceptor = value;
            }
        }
    }
}
