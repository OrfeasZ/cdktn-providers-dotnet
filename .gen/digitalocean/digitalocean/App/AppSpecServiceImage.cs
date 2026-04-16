using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecServiceImage")]
    public class AppSpecServiceImage : digitalocean.App.IAppSpecServiceImage
    {
        /// <summary>The registry type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#registry_type App#registry_type}
        /// </remarks>
        [JsiiProperty(name: "registryType", typeJson: "{\"primitive\":\"string\"}")]
        public string RegistryType
        {
            get;
            set;
        }

        /// <summary>The repository name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#repository App#repository}
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public string Repository
        {
            get;
            set;
        }

        private object? _deployOnPush;

        /// <summary>deploy_on_push block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#deploy_on_push App#deploy_on_push}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deployOnPush", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceImageDeployOnPush\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DeployOnPush
        {
            get => _deployOnPush;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecServiceImageDeployOnPush[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceImageDeployOnPush).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deployOnPush = value;
            }
        }

        /// <summary>The image digest. Cannot be specified if tag is provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#digest App#digest}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Digest
        {
            get;
            set;
        }

        /// <summary>The registry name. Must be left empty for the DOCR registry type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#registry App#registry}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Registry
        {
            get;
            set;
        }

        /// <summary>Access credentials for third-party registries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#registry_credentials App#registry_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryCredentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryCredentials
        {
            get;
            set;
        }

        /// <summary>The repository tag. Defaults to latest if not provided. Cannot be specified if digest is provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#tag App#tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tag
        {
            get;
            set;
        }
    }
}
