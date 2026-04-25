using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptBindingsOutbound), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptBindingsOutbound")]
    public interface IWorkersScriptBindingsOutbound
    {
        /// <summary>Pass information from the Dispatch Worker to the Outbound Worker through the parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#params WorkersScript#params}
        /// </remarks>
        [JsiiProperty(name: "params", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Params
        {
            get
            {
                return null;
            }
        }

        /// <summary>Outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#worker WorkersScript#worker}
        /// </remarks>
        [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsOutboundWorker\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptBindingsOutboundWorker? Worker
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptBindingsOutbound), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptBindingsOutbound")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptBindingsOutbound
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Pass information from the Dispatch Worker to the Outbound Worker through the parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#params WorkersScript#params}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "params", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Params
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Outbound worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#worker WorkersScript#worker}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsOutboundWorker\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptBindingsOutboundWorker? Worker
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptBindingsOutboundWorker?>();
            }
        }
    }
}
