using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceImage), fullyQualifiedName: "digitalocean.app.AppSpecServiceImage")]
    public interface IAppSpecServiceImage
    {
        /// <summary>The registry type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#registry_type App#registry_type}
        /// </remarks>
        [JsiiProperty(name: "registryType", typeJson: "{\"primitive\":\"string\"}")]
        string RegistryType
        {
            get;
        }

        /// <summary>The repository name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#repository App#repository}
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        string Repository
        {
            get;
        }

        /// <summary>deploy_on_push block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#deploy_on_push App#deploy_on_push}
        /// </remarks>
        [JsiiProperty(name: "deployOnPush", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceImageDeployOnPush\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeployOnPush
        {
            get
            {
                return null;
            }
        }

        /// <summary>The image digest. Cannot be specified if tag is provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#digest App#digest}
        /// </remarks>
        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Digest
        {
            get
            {
                return null;
            }
        }

        /// <summary>The registry name. Must be left empty for the DOCR registry type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#registry App#registry}
        /// </remarks>
        [JsiiProperty(name: "registry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Registry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Access credentials for third-party registries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#registry_credentials App#registry_credentials}
        /// </remarks>
        [JsiiProperty(name: "registryCredentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistryCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>The repository tag. Defaults to latest if not provided. Cannot be specified if digest is provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#tag App#tag}
        /// </remarks>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tag
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceImage), fullyQualifiedName: "digitalocean.app.AppSpecServiceImage")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceImage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The registry type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#registry_type App#registry_type}
            /// </remarks>
            [JsiiProperty(name: "registryType", typeJson: "{\"primitive\":\"string\"}")]
            public string RegistryType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The repository name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#repository App#repository}
            /// </remarks>
            [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
            public string Repository
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>deploy_on_push block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#deploy_on_push App#deploy_on_push}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deployOnPush", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceImageDeployOnPush\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeployOnPush
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The image digest. Cannot be specified if tag is provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#digest App#digest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Digest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The registry name. Must be left empty for the DOCR registry type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#registry App#registry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Registry
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Access credentials for third-party registries.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#registry_credentials App#registry_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registryCredentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryCredentials
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The repository tag. Defaults to latest if not provided. Cannot be specified if digest is provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#tag App#tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tag
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
