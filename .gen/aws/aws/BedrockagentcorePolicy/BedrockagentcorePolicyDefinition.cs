using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcorePolicy
{
    [JsiiByValue(fqn: "aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinition")]
    public class BedrockagentcorePolicyDefinition : aws.BedrockagentcorePolicy.IBedrockagentcorePolicyDefinition
    {
        private object? _cedar;

        /// <summary>cedar block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/bedrockagentcore_policy#cedar BedrockagentcorePolicy#cedar}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cedar", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinitionCedar\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Cedar
        {
            get => _cedar;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcorePolicy.IBedrockagentcorePolicyDefinitionCedar[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcorePolicy.IBedrockagentcorePolicyDefinitionCedar).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cedar = value;
            }
        }
    }
}
