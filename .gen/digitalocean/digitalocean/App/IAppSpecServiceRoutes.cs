using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceRoutes), fullyQualifiedName: "digitalocean.app.AppSpecServiceRoutes")]
    public interface IAppSpecServiceRoutes
    {
        /// <summary>Path specifies an route by HTTP path prefix.</summary>
        /// <remarks>
        /// Paths must start with / and must be unique within the app.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#path App#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional flag to preserve the path that is forwarded to the backend service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#preserve_path_prefix App#preserve_path_prefix}
        /// </remarks>
        [JsiiProperty(name: "preservePathPrefix", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreservePathPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceRoutes), fullyQualifiedName: "digitalocean.app.AppSpecServiceRoutes")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceRoutes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path specifies an route by HTTP path prefix.</summary>
            /// <remarks>
            /// Paths must start with / and must be unique within the app.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#path App#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An optional flag to preserve the path that is forwarded to the backend service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#preserve_path_prefix App#preserve_path_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preservePathPrefix", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreservePathPrefix
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
