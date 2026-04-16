using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecWorker")]
    public class AppSpecWorker : digitalocean.App.IAppSpecWorker
    {
        /// <summary>The name of the component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _alert;

        /// <summary>alert block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#alert App#alert}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Alert
        {
            get => _alert;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecWorkerAlert[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerAlert).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _alert = value;
            }
        }

        /// <summary>autoscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#autoscaling App#autoscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscaling\"}", isOptional: true)]
        public digitalocean.App.IAppSpecWorkerAutoscaling? Autoscaling
        {
            get;
            set;
        }

        /// <summary>bitbucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#bitbucket App#bitbucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerBitbucket\"}", isOptional: true)]
        public digitalocean.App.IAppSpecWorkerBitbucket? Bitbucket
        {
            get;
            set;
        }

        /// <summary>An optional build command to run while building this component from source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#build_command App#build_command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BuildCommand
        {
            get;
            set;
        }

        /// <summary>The path to a Dockerfile relative to the root of the repo. If set, overrides usage of buildpacks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#dockerfile_path App#dockerfile_path}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#env App#env}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecWorkerEnv[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerEnv).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _env = value;
            }
        }

        /// <summary>An environment slug describing the type of this app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#environment_slug App#environment_slug}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnvironmentSlug
        {
            get;
            set;
        }

        /// <summary>git block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#git App#git}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGit\"}", isOptional: true)]
        public digitalocean.App.IAppSpecWorkerGit? Git
        {
            get;
            set;
        }

        /// <summary>github block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#github App#github}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGithub\"}", isOptional: true)]
        public digitalocean.App.IAppSpecWorkerGithub? Github
        {
            get;
            set;
        }

        /// <summary>gitlab block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#gitlab App#gitlab}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGitlab\"}", isOptional: true)]
        public digitalocean.App.IAppSpecWorkerGitlab? Gitlab
        {
            get;
            set;
        }

        /// <summary>image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#image App#image}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerImage\"}", isOptional: true)]
        public digitalocean.App.IAppSpecWorkerImage? Image
        {
            get;
            set;
        }

        /// <summary>The amount of instances that this component should be scaled to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#instance_count App#instance_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        /// <summary>The instance size to use for this component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#instance_size_slug App#instance_size_slug}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceSizeSlug", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceSizeSlug
        {
            get;
            set;
        }

        private object? _logDestination;

        /// <summary>log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#log_destination App#log_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogDestination
        {
            get => _logDestination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecWorkerLogDestination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerLogDestination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logDestination = value;
            }
        }

        /// <summary>An optional run command to override the component's default.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#run_command App#run_command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RunCommand
        {
            get;
            set;
        }

        /// <summary>An optional path to the working directory to use for the build.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#source_dir App#source_dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDir
        {
            get;
            set;
        }

        /// <summary>termination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#termination App#termination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerTermination\"}", isOptional: true)]
        public digitalocean.App.IAppSpecWorkerTermination? Termination
        {
            get;
            set;
        }
    }
}
