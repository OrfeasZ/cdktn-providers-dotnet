using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecWorkerImageDeployOnPush), fullyQualifiedName: "digitalocean.app.AppSpecWorkerImageDeployOnPush")]
    public interface IAppSpecWorkerImageDeployOnPush
    {
        /// <summary>Whether to automatically deploy images pushed to DOCR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#enabled App#enabled}
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

        [JsiiTypeProxy(nativeType: typeof(IAppSpecWorkerImageDeployOnPush), fullyQualifiedName: "digitalocean.app.AppSpecWorkerImageDeployOnPush")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecWorkerImageDeployOnPush
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to automatically deploy images pushed to DOCR.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#enabled App#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
