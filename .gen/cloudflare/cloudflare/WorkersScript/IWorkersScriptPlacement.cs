using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptPlacement), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptPlacement")]
    public interface IWorkersScriptPlacement
    {
        /// <summary>Enables [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Available values: "smart", "targeted".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#mode WorkersScript#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptPlacement), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptPlacement")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptPlacement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Available values: "smart", "targeted".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#mode WorkersScript#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
