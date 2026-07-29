using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration")]
    public class BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration : aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
    {
        private object? _hostingEnvironment;

        /// <summary>hosting_environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_gateway#hosting_environment BedrockagentcoreGateway#hosting_environment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostingEnvironment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HostingEnvironment
        {
            get => _hostingEnvironment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hostingEnvironment = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_gateway#workload_identities BedrockagentcoreGateway#workload_identities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workloadIdentities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WorkloadIdentities
        {
            get;
            set;
        }
    }
}
