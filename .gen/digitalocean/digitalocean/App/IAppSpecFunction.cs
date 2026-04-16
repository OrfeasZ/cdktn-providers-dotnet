using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecFunction), fullyQualifiedName: "digitalocean.app.AppSpecFunction")]
    public interface IAppSpecFunction
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

        /// <summary>alert block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#alert App#alert}
        /// </remarks>
        [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Alert
        {
            get
            {
                return null;
            }
        }

        /// <summary>bitbucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#bitbucket App#bitbucket}
        /// </remarks>
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionBitbucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionBitbucket? Bitbucket
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
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionCors\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionCors? Cors
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
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Env
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
        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionGit? Git
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
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGithub\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionGithub? Github
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
        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGitlab\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecFunctionGitlab? Gitlab
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#log_destination App#log_destination}
        /// </remarks>
        [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogDestination
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
        [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        [JsiiTypeProxy(nativeType: typeof(IAppSpecFunction), fullyQualifiedName: "digitalocean.app.AppSpecFunction")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecFunction
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

            /// <summary>alert block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#alert App#alert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Alert
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>bitbucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#bitbucket App#bitbucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionBitbucket\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionBitbucket? Bitbucket
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionBitbucket?>();
            }

            /// <summary>cors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#cors App#cors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionCors\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionCors? Cors
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionCors?>();
            }

            /// <summary>env block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#env App#env}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Env
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>git block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#git App#git}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGit\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionGit? Git
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionGit?>();
            }

            /// <summary>github block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#github App#github}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGithub\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionGithub? Github
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionGithub?>();
            }

            /// <summary>gitlab block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#gitlab App#gitlab}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGitlab\"}", isOptional: true)]
            public digitalocean.App.IAppSpecFunctionGitlab? Gitlab
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionGitlab?>();
            }

            /// <summary>log_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#log_destination App#log_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogDestination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>routes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#routes App#routes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
