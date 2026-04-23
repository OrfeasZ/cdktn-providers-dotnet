using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#guardrail_identifier BedrockagentFlow#guardrail_identifier}.</summary>
        [JsiiProperty(name: "guardrailIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string GuardrailIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#guardrail_version BedrockagentFlow#guardrail_version}.</summary>
        [JsiiProperty(name: "guardrailVersion", typeJson: "{\"primitive\":\"string\"}")]
        string GuardrailVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#guardrail_identifier BedrockagentFlow#guardrail_identifier}.</summary>
            [JsiiProperty(name: "guardrailIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string GuardrailIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#guardrail_version BedrockagentFlow#guardrail_version}.</summary>
            [JsiiProperty(name: "guardrailVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string GuardrailVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
