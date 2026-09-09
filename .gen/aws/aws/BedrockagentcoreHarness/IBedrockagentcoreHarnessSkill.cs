using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessSkill), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkill")]
    public interface IBedrockagentcoreHarnessSkill
    {
        /// <summary>aws_skills block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#aws_skills BedrockagentcoreHarness#aws_skills}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillAwsSkills" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "awsSkills", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillAwsSkills\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsSkills
        {
            get
            {
                return null;
            }
        }

        /// <summary>git block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#git BedrockagentcoreHarness#git}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillGit" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "git", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Git
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

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#s3 BedrockagentcoreHarness#s3}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillS3" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessSkill), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkill")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkill
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_skills block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#aws_skills BedrockagentcoreHarness#aws_skills}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillAwsSkills" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsSkills", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillAwsSkills\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsSkills
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>git block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#git BedrockagentcoreHarness#git}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillGit" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "git", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillGit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Git
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

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#s3 BedrockagentcoreHarness#s3}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessSkillS3" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessSkillS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
