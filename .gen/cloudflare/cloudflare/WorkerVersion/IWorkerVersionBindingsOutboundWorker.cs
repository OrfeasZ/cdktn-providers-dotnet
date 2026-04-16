using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionBindingsOutboundWorker), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionBindingsOutboundWorker")]
    public interface IWorkerVersionBindingsOutboundWorker
    {
        /// <summary>Entrypoint to invoke on the outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#entrypoint WorkerVersion#entrypoint}
        /// </remarks>
        [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Entrypoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Environment of the outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#environment WorkerVersion#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#service WorkerVersion#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Service
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionBindingsOutboundWorker), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionBindingsOutboundWorker")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundWorker
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Entrypoint to invoke on the outbound worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#entrypoint WorkerVersion#entrypoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Entrypoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Environment of the outbound worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#environment WorkerVersion#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Environment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the outbound worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#service WorkerVersion#service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Service
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
