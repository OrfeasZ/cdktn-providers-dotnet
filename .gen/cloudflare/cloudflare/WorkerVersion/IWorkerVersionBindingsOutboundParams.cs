using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionBindingsOutboundParams), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionBindingsOutboundParams")]
    public interface IWorkerVersionBindingsOutboundParams
    {
        /// <summary>Name of the parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#name WorkerVersion#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionBindingsOutboundParams), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionBindingsOutboundParams")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundParams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the parameter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#name WorkerVersion#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
