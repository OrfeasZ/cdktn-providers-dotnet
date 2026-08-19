using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcorePolicy
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcorePolicyDefinitionCedar), fullyQualifiedName: "aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinitionCedar")]
    public interface IBedrockagentcorePolicyDefinitionCedar
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/bedrockagentcore_policy#statement BedrockagentcorePolicy#statement}.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"string\"}")]
        string Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcorePolicyDefinitionCedar), fullyQualifiedName: "aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinitionCedar")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcorePolicy.IBedrockagentcorePolicyDefinitionCedar
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/bedrockagentcore_policy#statement BedrockagentcorePolicy#statement}.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"string\"}")]
            public string Statement
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
