using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionConnectionConfigurationData), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionConnectionConfigurationData")]
    public interface IBedrockagentFlowDefinitionConnectionConfigurationData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#source_output BedrockagentFlow#source_output}.</summary>
        [JsiiProperty(name: "sourceOutput", typeJson: "{\"primitive\":\"string\"}")]
        string SourceOutput
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#target_input BedrockagentFlow#target_input}.</summary>
        [JsiiProperty(name: "targetInput", typeJson: "{\"primitive\":\"string\"}")]
        string TargetInput
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionConnectionConfigurationData), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionConnectionConfigurationData")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionConnectionConfigurationData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#source_output BedrockagentFlow#source_output}.</summary>
            [JsiiProperty(name: "sourceOutput", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceOutput
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#target_input BedrockagentFlow#target_input}.</summary>
            [JsiiProperty(name: "targetInput", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetInput
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
