using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecStaticSite")]
    public class AppSpecStaticSite : digitalocean.App.IAppSpecStaticSite
    {
        /// <summary>The name of the component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>bitbucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#bitbucket App#bitbucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteBitbucket\"}", isOptional: true)]
        public digitalocean.App.IAppSpecStaticSiteBitbucket? Bitbucket
        {
            get;
            set;
        }

        /// <summary>An optional build command to run while building this component from source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#build_command App#build_command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BuildCommand
        {
            get;
            set;
        }

        /// <summary>The name of the document to use as the fallback for any requests to documents that are not found when serving this static site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#catchall_document App#catchall_document}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "catchallDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CatchallDocument
        {
            get;
            set;
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cors App#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteCors\"}", isOptional: true)]
        public digitalocean.App.IAppSpecStaticSiteCors? Cors
        {
            get;
            set;
        }

        /// <summary>The path to a Dockerfile relative to the root of the repo. If set, overrides usage of buildpacks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#dockerfile_path App#dockerfile_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerfilePath
        {
            get;
            set;
        }

        private object? _env;

        /// <summary>env block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#env App#env}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Env
        {
            get => _env;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecStaticSiteEnv[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecStaticSiteEnv).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _env = value;
            }
        }

        /// <summary>An environment slug describing the type of this app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#environment_slug App#environment_slug}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnvironmentSlug
        {
            get;
            set;
        }

        /// <summary>The name of the error document to use when serving this static site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#error_document App#error_document}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ErrorDocument
        {
            get;
            set;
        }

        /// <summary>git block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#git App#git}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGit\"}", isOptional: true)]
        public digitalocean.App.IAppSpecStaticSiteGit? Git
        {
            get;
            set;
        }

        /// <summary>github block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#github App#github}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGithub\"}", isOptional: true)]
        public digitalocean.App.IAppSpecStaticSiteGithub? Github
        {
            get;
            set;
        }

        /// <summary>gitlab block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#gitlab App#gitlab}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGitlab\"}", isOptional: true)]
        public digitalocean.App.IAppSpecStaticSiteGitlab? Gitlab
        {
            get;
            set;
        }

        /// <summary>The name of the index document to use when serving this static site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#index_document App#index_document}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexDocument
        {
            get;
            set;
        }

        /// <summary>An optional path to where the built assets will be located, relative to the build context.</summary>
        /// <remarks>
        /// If not set, App Platform will automatically scan for these directory names: <c>_static</c>, <c>dist</c>, <c>public</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#output_dir App#output_dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputDir
        {
            get;
            set;
        }

        private object? _routes;

        /// <summary>routes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#routes App#routes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Routes
        {
            get => _routes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecStaticSiteRoutes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecStaticSiteRoutes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _routes = value;
            }
        }

        /// <summary>An optional path to the working directory to use for the build.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#source_dir App#source_dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDir
        {
            get;
            set;
        }
    }
}
