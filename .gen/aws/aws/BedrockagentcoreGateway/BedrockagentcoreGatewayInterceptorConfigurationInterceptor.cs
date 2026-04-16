using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptor")]
    public class BedrockagentcoreGatewayInterceptorConfigurationInterceptor : aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInterceptor
    {
        private object? _lambda;

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#lambda BedrockagentcoreGateway#lambda}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Lambda
        {
            get => _lambda;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambda = value;
            }
        }
    }
}
