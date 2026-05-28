using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessToolConfig), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfig")]
    public interface IBedrockagentcoreHarnessToolConfig
    {
        /// <summary>agentcore_browser block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#agentcore_browser BedrockagentcoreHarness#agentcore_browser}
        /// </remarks>
        [JsiiProperty(name: "agentcoreBrowser", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreBrowser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AgentcoreBrowser
        {
            get
            {
                return null;
            }
        }

        /// <summary>agentcore_code_interpreter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#agentcore_code_interpreter BedrockagentcoreHarness#agentcore_code_interpreter}
        /// </remarks>
        [JsiiProperty(name: "agentcoreCodeInterpreter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AgentcoreCodeInterpreter
        {
            get
            {
                return null;
            }
        }

        /// <summary>agentcore_gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#agentcore_gateway BedrockagentcoreHarness#agentcore_gateway}
        /// </remarks>
        [JsiiProperty(name: "agentcoreGateway", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreGateway\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AgentcoreGateway
        {
            get
            {
                return null;
            }
        }

        /// <summary>inline_function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#inline_function BedrockagentcoreHarness#inline_function}
        /// </remarks>
        [JsiiProperty(name: "inlineFunction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigInlineFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InlineFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>remote_mcp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#remote_mcp BedrockagentcoreHarness#remote_mcp}
        /// </remarks>
        [JsiiProperty(name: "remoteMcp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigRemoteMcp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RemoteMcp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessToolConfig), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>agentcore_browser block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#agentcore_browser BedrockagentcoreHarness#agentcore_browser}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentcoreBrowser", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreBrowser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AgentcoreBrowser
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>agentcore_code_interpreter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#agentcore_code_interpreter BedrockagentcoreHarness#agentcore_code_interpreter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentcoreCodeInterpreter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AgentcoreCodeInterpreter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>agentcore_gateway block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#agentcore_gateway BedrockagentcoreHarness#agentcore_gateway}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentcoreGateway", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreGateway\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AgentcoreGateway
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>inline_function block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#inline_function BedrockagentcoreHarness#inline_function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inlineFunction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigInlineFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InlineFunction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>remote_mcp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#remote_mcp BedrockagentcoreHarness#remote_mcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remoteMcp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigRemoteMcp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RemoteMcp
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
