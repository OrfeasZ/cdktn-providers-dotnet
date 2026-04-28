using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecService), fullyQualifiedName: "digitalocean.app.AppSpecService")]
    public interface IAppSpecService
    {
        /// <summary>The name of the component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>alert block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#alert App#alert}
        /// </remarks>
        [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#autoscaling App#autoscaling}
        /// </remarks>
        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceAutoscaling? Autoscaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>bitbucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#bitbucket App#bitbucket}
        /// </remarks>
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceBitbucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceBitbucket? Bitbucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional build command to run while building this component from source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#build_command App#build_command}
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

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cors App#cors}
        /// </remarks>
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceCors\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceCors? Cors
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a Dockerfile relative to the root of the repo. If set, overrides usage of buildpacks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#dockerfile_path App#dockerfile_path}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#env App#env}
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#environment_slug App#environment_slug}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#git App#git}
        /// </remarks>
        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceGit? Git
        {
            get
            {
                return null;
            }
        }

        /// <summary>github block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#github App#github}
        /// </remarks>
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGithub\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceGithub? Github
        {
            get
            {
                return null;
            }
        }

        /// <summary>gitlab block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#gitlab App#gitlab}
        /// </remarks>
        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGitlab\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceGitlab? Gitlab
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#health_check App#health_check}
        /// </remarks>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceHealthCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceHealthCheck? HealthCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>The internal port on which this service's run command will listen.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#http_port App#http_port}
        /// </remarks>
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#image App#image}
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceImage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceImage? Image
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of instances that this component should be scaled to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#instance_count App#instance_count}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#instance_size_slug App#instance_size_slug}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#internal_ports App#internal_ports}.</summary>
        [JsiiProperty(name: "internalPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? InternalPorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#log_destination App#log_destination}
        /// </remarks>
        [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#routes App#routes}
        /// </remarks>
        [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Routes
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional run command to override the component's default.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#run_command App#run_command}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#source_dir App#source_dir}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#termination App#termination}
        /// </remarks>
        [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceTermination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceTermination? Termination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecService), fullyQualifiedName: "digitalocean.app.AppSpecService")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the component.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#name App#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>alert block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#alert App#alert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Alert
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>autoscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#autoscaling App#autoscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscaling\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceAutoscaling? Autoscaling
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAutoscaling?>();
            }

            /// <summary>bitbucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#bitbucket App#bitbucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceBitbucket\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceBitbucket? Bitbucket
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceBitbucket?>();
            }

            /// <summary>An optional build command to run while building this component from source.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#build_command App#build_command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildCommand
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cors App#cors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceCors\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceCors? Cors
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceCors?>();
            }

            /// <summary>The path to a Dockerfile relative to the root of the repo. If set, overrides usage of buildpacks.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#dockerfile_path App#dockerfile_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerfilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>env block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#env App#env}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Env
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>An environment slug describing the type of this app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#environment_slug App#environment_slug}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnvironmentSlug
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>git block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#git App#git}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGit\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceGit? Git
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceGit?>();
            }

            /// <summary>github block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#github App#github}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGithub\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceGithub? Github
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceGithub?>();
            }

            /// <summary>gitlab block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#gitlab App#gitlab}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGitlab\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceGitlab? Gitlab
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceGitlab?>();
            }

            /// <summary>health_check block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#health_check App#health_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceHealthCheck\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceHealthCheck? HealthCheck
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceHealthCheck?>();
            }

            /// <summary>The internal port on which this service's run command will listen.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#http_port App#http_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#image App#image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceImage\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceImage? Image
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceImage?>();
            }

            /// <summary>The amount of instances that this component should be scaled to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#instance_count App#instance_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The instance size to use for this component.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#instance_size_slug App#instance_size_slug}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceSizeSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceSizeSlug
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#internal_ports App#internal_ports}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internalPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? InternalPorts
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>log_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#log_destination App#log_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogDestination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>routes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#routes App#routes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Routes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>An optional run command to override the component's default.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#run_command App#run_command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunCommand
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An optional path to the working directory to use for the build.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#source_dir App#source_dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceDir
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>termination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#termination App#termination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceTermination\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceTermination? Termination
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceTermination?>();
            }
        }
    }
}
