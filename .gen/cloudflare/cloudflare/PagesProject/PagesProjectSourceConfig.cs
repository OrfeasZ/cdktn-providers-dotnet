using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectSourceConfig")]
    public class PagesProjectSourceConfig : cloudflare.PagesProject.IPagesProjectSourceConfig
    {
        private object? _deploymentsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#deployments_enabled PagesProject#deployments_enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#owner PagesProject#owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Owner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#path_excludes PagesProject#path_excludes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pathExcludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PathExcludes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#path_includes PagesProject#path_includes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pathIncludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PathIncludes
        {
            get;
            set;
        }

        private object? _prCommentsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#pr_comments_enabled PagesProject#pr_comments_enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_branch_excludes PagesProject#preview_branch_excludes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "previewBranchExcludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PreviewBranchExcludes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_branch_includes PagesProject#preview_branch_includes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "previewBranchIncludes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PreviewBranchIncludes
        {
            get;
            set;
        }

        /// <summary>Available values: "all", "none", "custom".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#preview_deployment_setting PagesProject#preview_deployment_setting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "previewDeploymentSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreviewDeploymentSetting
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#production_branch PagesProject#production_branch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "productionBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProductionBranch
        {
            get;
            set;
        }

        private object? _productionDeploymentsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#production_deployments_enabled PagesProject#production_deployments_enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#repo_name PagesProject#repo_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repoName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepoName
        {
            get;
            set;
        }
    }
}
