using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue")]
    public class BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime#claim_match_operator BedrockagentcoreAgentRuntime#claim_match_operator}.</summary>
        [JsiiProperty(name: "claimMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
        public string ClaimMatchOperator
        {
            get;
            set;
        }

        private object? _claimMatchValue;

        /// <summary>claim_match_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime#claim_match_value BedrockagentcoreAgentRuntime#claim_match_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "claimMatchValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClaimMatchValue
        {
            get => _claimMatchValue;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _claimMatchValue = value;
            }
        }
    }
}
