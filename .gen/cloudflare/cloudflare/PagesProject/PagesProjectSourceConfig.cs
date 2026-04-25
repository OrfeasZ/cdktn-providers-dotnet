using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectSourceConfig")]
    public class PagesProjectSourceConfig : cloudflare.PagesProject.IPagesProjectSourceConfig
    {
        private object? _deploymentsEnabled;

        /// <summary>Whether to enable automatic deployments when pushing to the source repository.</summary>
        /// <remarks>
        /// When disabled, no deployments (production or preview) will be triggered automatically.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#deployments_enabled PagesProject#deployments_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DeploymentsEnabled
        {
            get => _deploymentsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deploymentsEnabled = value;
            }
        }

        /// <summary>The owner of the repository.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#owner PagesProject#owner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Owner
        {
            get;
            set;
        }

        /// <summary>The owner ID of the repository.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#owner_id PagesProject#owner_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OwnerId
        {
            get;
            set;
        }

        /// <summary>A list of paths that should be excluded from triggering a preview deployment. Wildcard syntax (`*`) is supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#path_excludes PagesProject#path_excludes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathExcludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PathExcludes
        {
            get;
            set;
        }

        /// <summary>A list of paths that should be watched to trigger a preview deployment. Wildcard syntax (`*`) is supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#path_includes PagesProject#path_includes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathIncludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PathIncludes
        {
            get;
            set;
        }

        private object? _prCommentsEnabled;

        /// <summary>Whether to enable PR comments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#pr_comments_enabled PagesProject#pr_comments_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prCommentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PrCommentsEnabled
        {
            get => _prCommentsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _prCommentsEnabled = value;
            }
        }

        /// <summary>A list of branches that should not trigger a preview deployment.</summary>
        /// <remarks>
        /// Wildcard syntax (<c>*</c>) is supported. Must be used with <c>preview_deployment_setting</c> set to <c>custom</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#preview_branch_excludes PagesProject#preview_branch_excludes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "previewBranchExcludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PreviewBranchExcludes
        {
            get;
            set;
        }

        /// <summary>A list of branches that should trigger a preview deployment.</summary>
        /// <remarks>
        /// Wildcard syntax (<c>*</c>) is supported. Must be used with <c>preview_deployment_setting</c> set to <c>custom</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#preview_branch_includes PagesProject#preview_branch_includes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "previewBranchIncludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PreviewBranchIncludes
        {
            get;
            set;
        }

        /// <summary>Controls whether commits to preview branches trigger a preview deployment. Available values: "all", "none", "custom".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#preview_deployment_setting PagesProject#preview_deployment_setting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "previewDeploymentSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreviewDeploymentSetting
        {
            get;
            set;
        }

        /// <summary>The production branch of the repository.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#production_branch PagesProject#production_branch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productionBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProductionBranch
        {
            get;
            set;
        }

        private object? _productionDeploymentsEnabled;

        /// <summary>Whether to trigger a production deployment on commits to the production branch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#production_deployments_enabled PagesProject#production_deployments_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productionDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ProductionDeploymentsEnabled
        {
            get => _productionDeploymentsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _productionDeploymentsEnabled = value;
            }
        }

        /// <summary>The ID of the repository.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#repo_id PagesProject#repo_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepoId
        {
            get;
            set;
        }

        /// <summary>The name of the repository.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#repo_name PagesProject#repo_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repoName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepoName
        {
            get;
            set;
        }
    }
}
