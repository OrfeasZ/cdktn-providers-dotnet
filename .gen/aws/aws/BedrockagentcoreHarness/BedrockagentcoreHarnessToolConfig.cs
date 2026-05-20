using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfig")]
    public class BedrockagentcoreHarnessToolConfig : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfig
    {
        private object? _agentcoreBrowser;

        /// <summary>agentcore_browser block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#agentcore_browser BedrockagentcoreHarness#agentcore_browser}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agentcoreBrowser", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreBrowser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AgentcoreBrowser
        {
            get => _agentcoreBrowser;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreBrowser[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreBrowser).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _agentcoreBrowser = value;
            }
        }

        private object? _agentcoreCodeInterpreter;

        /// <summary>agentcore_code_interpreter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#agentcore_code_interpreter BedrockagentcoreHarness#agentcore_code_interpreter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agentcoreCodeInterpreter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AgentcoreCodeInterpreter
        {
            get => _agentcoreCodeInterpreter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreCodeInterpreter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _agentcoreCodeInterpreter = value;
            }
        }

        private object? _agentcoreGateway;

        /// <summary>agentcore_gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#agentcore_gateway BedrockagentcoreHarness#agentcore_gateway}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agentcoreGateway", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigAgentcoreGateway\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AgentcoreGateway
        {
            get => _agentcoreGateway;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreGateway[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigAgentcoreGateway).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _agentcoreGateway = value;
            }
        }

        private object? _inlineFunction;

        /// <summary>inline_function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#inline_function BedrockagentcoreHarness#inline_function}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inlineFunction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigInlineFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InlineFunction
        {
            get => _inlineFunction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigInlineFunction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigInlineFunction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inlineFunction = value;
            }
        }

        private object? _remoteMcp;

        /// <summary>remote_mcp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_harness#remote_mcp BedrockagentcoreHarness#remote_mcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteMcp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessToolConfigRemoteMcp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RemoteMcp
        {
            get => _remoteMcp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigRemoteMcp[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessToolConfigRemoteMcp).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _remoteMcp = value;
            }
        }
    }
}
