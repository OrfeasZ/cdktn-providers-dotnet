using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecMaintenance), fullyQualifiedName: "digitalocean.app.AppSpecMaintenance")]
    public interface IAppSpecMaintenance
    {
        /// <summary>Indicates whether the app should be archived. Setting this to true implies that enabled is set to true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#archive App#archive}
        /// </remarks>
        [JsiiProperty(name: "archive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Archive
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether maintenance mode should be enabled for the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#enabled App#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>A custom offline page to display when maintenance mode is enabled or the app is archived.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#offline_page_url App#offline_page_url}
        /// </remarks>
        [JsiiProperty(name: "offlinePageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OfflinePageUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecMaintenance), fullyQualifiedName: "digitalocean.app.AppSpecMaintenance")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecMaintenance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates whether the app should be archived. Setting this to true implies that enabled is set to true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#archive App#archive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "archive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Archive
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates whether maintenance mode should be enabled for the app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#enabled App#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A custom offline page to display when maintenance mode is enabled or the app is archived.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#offline_page_url App#offline_page_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "offlinePageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OfflinePageUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
