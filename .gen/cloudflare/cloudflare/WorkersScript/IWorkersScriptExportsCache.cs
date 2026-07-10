using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptExportsCache), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptExportsCache")]
    public interface IWorkersScriptExportsCache
    {
        /// <summary>Whether caching is enabled for this entrypoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/workers_script#enabled WorkersScript#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptExportsCache), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptExportsCache")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptExportsCache
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether caching is enabled for this entrypoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/workers_script#enabled WorkersScript#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
