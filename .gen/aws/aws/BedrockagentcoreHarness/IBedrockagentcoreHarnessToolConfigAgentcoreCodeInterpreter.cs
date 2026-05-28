using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter")]
    public interface IBedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#code_interpreter_arn BedrockagentcoreHarness#code_interpreter_arn}.</summary>
        [JsiiProperty(name: "codeInterpreterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CodeInterpreterArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#code_interpreter_arn BedrockagentcoreHarness#code_interpreter_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "codeInterpreterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CodeInterpreterArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
