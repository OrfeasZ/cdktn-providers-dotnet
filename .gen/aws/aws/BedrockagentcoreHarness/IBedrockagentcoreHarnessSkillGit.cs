using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessSkillGit), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGit")]
    public interface IBedrockagentcoreHarnessSkillGit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#url BedrockagentcoreHarness#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#auth BedrockagentcoreHarness#auth}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillGitAuth" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "auth", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGitAuth\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Auth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#path BedrockagentcoreHarness#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessSkillGit), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGit")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillGit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#url BedrockagentcoreHarness#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#auth BedrockagentcoreHarness#auth}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillGitAuth" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auth", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGitAuth\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Auth
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#path BedrockagentcoreHarness#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
