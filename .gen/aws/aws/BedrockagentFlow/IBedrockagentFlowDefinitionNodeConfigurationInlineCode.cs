using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationInlineCode), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationInlineCode")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationInlineCode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#code BedrockagentFlow#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        string Code
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#language BedrockagentFlow#language}.</summary>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        string Language
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationInlineCode), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationInlineCode")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationInlineCode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#code BedrockagentFlow#code}.</summary>
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
            public string Code
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_flow#language BedrockagentFlow#language}.</summary>
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
            public string Language
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
