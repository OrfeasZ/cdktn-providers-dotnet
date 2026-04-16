using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecStaticSite), fullyQualifiedName: "digitalocean.app.AppSpecStaticSite")]
    public interface IAppSpecStaticSite
    {
        /// <summary>The name of the component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>bitbucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#bitbucket App#bitbucket}
        /// </remarks>
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteBitbucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecStaticSiteBitbucket? Bitbucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional build command to run while building this component from source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#build_command App#build_command}
        /// </remarks>
        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuildCommand
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the document to use as the fallback for any requests to documents that are not found when serving this static site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#catchall_document App#catchall_document}
        /// </remarks>
        [JsiiProperty(name: "catchallDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatchallDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#cors App#cors}
        /// </remarks>
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteCors\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecStaticSiteCors? Cors
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a Dockerfile relative to the root of the repo. If set, overrides usage of buildpacks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#dockerfile_path App#dockerfile_path}
        /// </remarks>
        [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerfilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>env block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#env App#env}
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>An environment slug describing the type of this app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#environment_slug App#environment_slug}
        /// </remarks>
        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnvironmentSlug
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the error document to use when serving this static site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#error_document App#error_document}
        /// </remarks>
        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ErrorDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>git block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#git App#git}
        /// </remarks>
        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecStaticSiteGit? Git
        {
            get
            {
                return null;
            }
        }

        /// <summary>github block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#github App#github}
        /// </remarks>
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGithub\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecStaticSiteGithub? Github
        {
            get
            {
                return null;
            }
        }

        /// <summary>gitlab block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#gitlab App#gitlab}
        /// </remarks>
        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGitlab\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecStaticSiteGitlab? Gitlab
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the index document to use when serving this static site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#index_document App#index_document}
        /// </remarks>
        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional path to where the built assets will be located, relative to the build context.</summary>
        /// <remarks>
        /// If not set, App Platform will automatically scan for these directory names: <c>_static</c>, <c>dist</c>, <c>public</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#output_dir App#output_dir}
        /// </remarks>
        [JsiiProperty(name: "outputDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputDir
        {
            get
            {
                return null;
            }
        }

        /// <summary>routes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#routes App#routes}
        /// </remarks>
        [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Routes
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional path to the working directory to use for the build.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#source_dir App#source_dir}
        /// </remarks>
        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceDir
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecStaticSite), fullyQualifiedName: "digitalocean.app.AppSpecStaticSite")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecStaticSite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the component.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#name App#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>bitbucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#bitbucket App#bitbucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteBitbucket\"}", isOptional: true)]
            public digitalocean.App.IAppSpecStaticSiteBitbucket? Bitbucket
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteBitbucket?>();
            }

            /// <summary>An optional build command to run while building this component from source.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#build_command App#build_command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildCommand
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the document to use as the fallback for any requests to documents that are not found when serving this static site.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#catchall_document App#catchall_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "catchallDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatchallDocument
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#cors App#cors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteCors\"}", isOptional: true)]
            public digitalocean.App.IAppSpecStaticSiteCors? Cors
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteCors?>();
            }

            /// <summary>The path to a Dockerfile relative to the root of the repo. If set, overrides usage of buildpacks.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#dockerfile_path App#dockerfile_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerfilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>env block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#env App#env}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Env
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>An environment slug describing the type of this app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#environment_slug App#environment_slug}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnvironmentSlug
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the error document to use when serving this static site.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#error_document App#error_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ErrorDocument
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>git block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#git App#git}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGit\"}", isOptional: true)]
            public digitalocean.App.IAppSpecStaticSiteGit? Git
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteGit?>();
            }

            /// <summary>github block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#github App#github}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGithub\"}", isOptional: true)]
            public digitalocean.App.IAppSpecStaticSiteGithub? Github
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteGithub?>();
            }

            /// <summary>gitlab block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#gitlab App#gitlab}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGitlab\"}", isOptional: true)]
            public digitalocean.App.IAppSpecStaticSiteGitlab? Gitlab
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteGitlab?>();
            }

            /// <summary>The name of the index document to use when serving this static site.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#index_document App#index_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexDocument
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An optional path to where the built assets will be located, relative to the build context.</summary>
            /// <remarks>
            /// If not set, App Platform will automatically scan for these directory names: <c>_static</c>, <c>dist</c>, <c>public</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#output_dir App#output_dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outputDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputDir
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>routes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#routes App#routes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Routes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>An optional path to the working directory to use for the build.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#source_dir App#source_dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceDir
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
