using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionBindingsOutbound), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionBindingsOutbound")]
    public interface IWorkerVersionBindingsOutbound
    {
        /// <summary>Pass information from the Dispatch Worker to the Outbound Worker through the parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#params WorkerVersion#params}
        /// </remarks>
        [JsiiProperty(name: "params", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutboundParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Params
        {
            get
            {
                return null;
            }
        }

        /// <summary>Outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#worker WorkerVersion#worker}
        /// </remarks>
        [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutboundWorker\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundWorker? Worker
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionBindingsOutbound), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionBindingsOutbound")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionBindingsOutbound
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Pass information from the Dispatch Worker to the Outbound Worker through the parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#params WorkerVersion#params}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "params", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutboundParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Params
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Outbound worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#worker WorkerVersion#worker}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutboundWorker\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundWorker? Worker
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundWorker?>();
            }
        }
    }
}
