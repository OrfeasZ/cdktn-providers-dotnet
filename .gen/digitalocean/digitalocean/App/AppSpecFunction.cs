using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecFunction")]
    public class AppSpecFunction : digitalocean.App.IAppSpecFunction
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
        [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecFunctionAlert[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionAlert).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _alert = value;
            }
        }

        /// <summary>bitbucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#bitbucket App#bitbucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionBitbucket\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionBitbucket? Bitbucket
        {
            get;
            set;
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#cors App#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionCors\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionCors? Cors
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
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecFunctionEnv[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionEnv).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _env = value;
            }
        }

        /// <summary>git block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#git App#git}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGit\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionGit? Git
        {
            get;
            set;
        }

        /// <summary>github block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#github App#github}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGithub\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionGithub? Github
        {
            get;
            set;
        }

        /// <summary>gitlab block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#gitlab App#gitlab}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionGitlab\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionGitlab? Gitlab
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
        [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecFunctionLogDestination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionLogDestination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logDestination = value;
            }
        }

        private object? _routes;

        /// <summary>routes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#routes App#routes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunctionRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecFunctionRoutes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionRoutes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _routes = value;
            }
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
    }
}
