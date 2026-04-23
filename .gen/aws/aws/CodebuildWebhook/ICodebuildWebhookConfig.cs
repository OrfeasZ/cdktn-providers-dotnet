using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildWebhook
{
    [JsiiInterface(nativeType: typeof(ICodebuildWebhookConfig), fullyQualifiedName: "aws.codebuildWebhook.CodebuildWebhookConfig")]
    public interface ICodebuildWebhookConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#project_name CodebuildWebhook#project_name}.</summary>
        [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#branch_filter CodebuildWebhook#branch_filter}.</summary>
        [JsiiProperty(name: "branchFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BranchFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#build_type CodebuildWebhook#build_type}.</summary>
        [JsiiProperty(name: "buildType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuildType
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#filter_group CodebuildWebhook#filter_group}
        /// </remarks>
        [JsiiProperty(name: "filterGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildWebhook.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FilterGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#id CodebuildWebhook#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#manual_creation CodebuildWebhook#manual_creation}.</summary>
        [JsiiProperty(name: "manualCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManualCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>pull_request_build_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#pull_request_build_policy CodebuildWebhook#pull_request_build_policy}
        /// </remarks>
        [JsiiProperty(name: "pullRequestBuildPolicy", typeJson: "{\"fqn\":\"aws.codebuildWebhook.CodebuildWebhookPullRequestBuildPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodebuildWebhook.ICodebuildWebhookPullRequestBuildPolicy? PullRequestBuildPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#region CodebuildWebhook#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>scope_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#scope_configuration CodebuildWebhook#scope_configuration}
        /// </remarks>
        [JsiiProperty(name: "scopeConfiguration", typeJson: "{\"fqn\":\"aws.codebuildWebhook.CodebuildWebhookScopeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodebuildWebhook.ICodebuildWebhookScopeConfiguration? ScopeConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildWebhookConfig), fullyQualifiedName: "aws.codebuildWebhook.CodebuildWebhookConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildWebhook.ICodebuildWebhookConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#project_name CodebuildWebhook#project_name}.</summary>
            [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#branch_filter CodebuildWebhook#branch_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "branchFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BranchFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#build_type CodebuildWebhook#build_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "buildType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#filter_group CodebuildWebhook#filter_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildWebhook.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FilterGroup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#id CodebuildWebhook#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#manual_creation CodebuildWebhook#manual_creation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "manualCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ManualCreation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>pull_request_build_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#pull_request_build_policy CodebuildWebhook#pull_request_build_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pullRequestBuildPolicy", typeJson: "{\"fqn\":\"aws.codebuildWebhook.CodebuildWebhookPullRequestBuildPolicy\"}", isOptional: true)]
            public aws.CodebuildWebhook.ICodebuildWebhookPullRequestBuildPolicy? PullRequestBuildPolicy
            {
                get => GetInstanceProperty<aws.CodebuildWebhook.ICodebuildWebhookPullRequestBuildPolicy?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#region CodebuildWebhook#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scope_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#scope_configuration CodebuildWebhook#scope_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopeConfiguration", typeJson: "{\"fqn\":\"aws.codebuildWebhook.CodebuildWebhookScopeConfiguration\"}", isOptional: true)]
            public aws.CodebuildWebhook.ICodebuildWebhookScopeConfiguration? ScopeConfiguration
            {
                get => GetInstanceProperty<aws.CodebuildWebhook.ICodebuildWebhookScopeConfiguration?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
