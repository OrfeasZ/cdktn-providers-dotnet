using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectSourceConfig), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectSourceConfig")]
    public interface IPagesProjectSourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#deployments_enabled PagesProject#deployments_enabled}.</summary>
        [JsiiProperty(name: "deploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeploymentsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#owner PagesProject#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Owner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#path_excludes PagesProject#path_excludes}.</summary>
        [JsiiProperty(name: "pathExcludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PathExcludes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#path_includes PagesProject#path_includes}.</summary>
        [JsiiProperty(name: "pathIncludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PathIncludes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#pr_comments_enabled PagesProject#pr_comments_enabled}.</summary>
        [JsiiProperty(name: "prCommentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrCommentsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_branch_excludes PagesProject#preview_branch_excludes}.</summary>
        [JsiiProperty(name: "previewBranchExcludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PreviewBranchExcludes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_branch_includes PagesProject#preview_branch_includes}.</summary>
        [JsiiProperty(name: "previewBranchIncludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PreviewBranchIncludes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "all", "none", "custom".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_deployment_setting PagesProject#preview_deployment_setting}
        /// </remarks>
        [JsiiProperty(name: "previewDeploymentSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreviewDeploymentSetting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#production_branch PagesProject#production_branch}.</summary>
        [JsiiProperty(name: "productionBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProductionBranch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#production_deployments_enabled PagesProject#production_deployments_enabled}.</summary>
        [JsiiProperty(name: "productionDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProductionDeploymentsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#repo_name PagesProject#repo_name}.</summary>
        [JsiiProperty(name: "repoName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepoName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectSourceConfig), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectSourceConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectSourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#deployments_enabled PagesProject#deployments_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeploymentsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#owner PagesProject#owner}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Owner
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#path_excludes PagesProject#path_excludes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pathExcludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PathExcludes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#path_includes PagesProject#path_includes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pathIncludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PathIncludes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#pr_comments_enabled PagesProject#pr_comments_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prCommentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PrCommentsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_branch_excludes PagesProject#preview_branch_excludes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "previewBranchExcludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PreviewBranchExcludes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_branch_includes PagesProject#preview_branch_includes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "previewBranchIncludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PreviewBranchIncludes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Available values: "all", "none", "custom".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_deployment_setting PagesProject#preview_deployment_setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "previewDeploymentSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreviewDeploymentSetting
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#production_branch PagesProject#production_branch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "productionBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProductionBranch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#production_deployments_enabled PagesProject#production_deployments_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "productionDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ProductionDeploymentsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#repo_name PagesProject#repo_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repoName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepoName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
