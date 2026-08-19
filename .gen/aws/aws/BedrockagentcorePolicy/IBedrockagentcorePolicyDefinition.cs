using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcorePolicy
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcorePolicyDefinition), fullyQualifiedName: "aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinition")]
    public interface IBedrockagentcorePolicyDefinition
    {
        /// <summary>cedar block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/bedrockagentcore_policy#cedar BedrockagentcorePolicy#cedar}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcorePolicy.IBedrockagentcorePolicyDefinitionCedar" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cedar", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinitionCedar\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Cedar
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcorePolicyDefinition), fullyQualifiedName: "aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcorePolicy.IBedrockagentcorePolicyDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cedar block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/bedrockagentcore_policy#cedar BedrockagentcorePolicy#cedar}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcorePolicy.IBedrockagentcorePolicyDefinitionCedar" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cedar", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinitionCedar\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Cedar
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
