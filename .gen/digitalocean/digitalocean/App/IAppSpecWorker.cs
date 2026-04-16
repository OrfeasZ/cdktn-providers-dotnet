using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecWorker), fullyQualifiedName: "digitalocean.app.AppSpecWorker")]
    public interface IAppSpecWorker
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
        [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Alert
        {
            get
            {
                return null;
            }
        }

        /// <summary>autoscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#autoscaling App#autoscaling}
        /// </remarks>
        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerAutoscaling? Autoscaling
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
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerBitbucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerBitbucket? Bitbucket
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
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        /// <summary>git block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#git App#git}
        /// </remarks>
        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerGit? Git
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
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGithub\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerGithub? Github
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
        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGitlab\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerGitlab? Gitlab
        {
            get
            {
                return null;
            }
        }

        /// <summary>image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#image App#image}
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerImage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerImage? Image
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of instances that this component should be scaled to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#instance_count App#instance_count}
        /// </remarks>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The instance size to use for this component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#instance_size_slug App#instance_size_slug}
        /// </remarks>
        [JsiiProperty(name: "instanceSizeSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceSizeSlug
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
        [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional run command to override the component's default.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#run_command App#run_command}
        /// </remarks>
        [JsiiProperty(name: "runCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RunCommand
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

        /// <summary>termination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#termination App#termination}
        /// </remarks>
        [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerTermination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecWorkerTermination? Termination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecWorker), fullyQualifiedName: "digitalocean.app.AppSpecWorker")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecWorker
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
            [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Alert
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>autoscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#autoscaling App#autoscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscaling\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerAutoscaling? Autoscaling
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerAutoscaling?>();
            }

            /// <summary>bitbucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#bitbucket App#bitbucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerBitbucket\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerBitbucket? Bitbucket
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerBitbucket?>();
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
            [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

            /// <summary>git block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#git App#git}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGit\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerGit? Git
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerGit?>();
            }

            /// <summary>github block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#github App#github}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGithub\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerGithub? Github
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerGithub?>();
            }

            /// <summary>gitlab block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#gitlab App#gitlab}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGitlab\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerGitlab? Gitlab
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerGitlab?>();
            }

            /// <summary>image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#image App#image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerImage\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerImage? Image
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerImage?>();
            }

            /// <summary>The amount of instances that this component should be scaled to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#instance_count App#instance_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The instance size to use for this component.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#instance_size_slug App#instance_size_slug}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceSizeSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceSizeSlug
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>log_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#log_destination App#log_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogDestination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>An optional run command to override the component's default.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#run_command App#run_command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunCommand
            {
                get => GetInstanceProperty<string?>();
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

            /// <summary>termination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#termination App#termination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerTermination\"}", isOptional: true)]
            public digitalocean.App.IAppSpecWorkerTermination? Termination
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerTermination?>();
            }
        }
    }
}
