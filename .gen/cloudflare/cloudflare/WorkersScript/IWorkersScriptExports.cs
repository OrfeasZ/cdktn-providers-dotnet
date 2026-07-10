using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptExports), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptExports")]
    public interface IWorkersScriptExports
    {
        /// <summary>The kind of entrypoint. A `type: worker` entry overrides the top-level `cache_options` for this specific entrypoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/workers_script#type WorkersScript#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Per-entrypoint cache override. When present, this overrides the top-level `cache_options` for this specific entrypoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/workers_script#cache WorkersScript#cache}
        /// </remarks>
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptExportsCache\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptExportsCache? Cache
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptExports), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptExports")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptExports
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The kind of entrypoint. A `type: worker` entry overrides the top-level `cache_options` for this specific entrypoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/workers_script#type WorkersScript#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Per-entrypoint cache override. When present, this overrides the top-level `cache_options` for this specific entrypoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/workers_script#cache WorkersScript#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptExportsCache\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptExportsCache? Cache
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptExportsCache?>();
            }
        }
    }
}
