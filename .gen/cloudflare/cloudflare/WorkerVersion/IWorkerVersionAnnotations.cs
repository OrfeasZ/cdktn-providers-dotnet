using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionAnnotations), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionAnnotations")]
    public interface IWorkerVersionAnnotations
    {
        /// <summary>Human-readable message about the version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#workers_message WorkerVersion#workers_message}
        /// </remarks>
        [JsiiProperty(name: "workersMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkersMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>User-provided identifier for the version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#workers_tag WorkerVersion#workers_tag}
        /// </remarks>
        [JsiiProperty(name: "workersTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkersTag
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionAnnotations), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionAnnotations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionAnnotations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Human-readable message about the version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#workers_message WorkerVersion#workers_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workersMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkersMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-provided identifier for the version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#workers_tag WorkerVersion#workers_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workersTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkersTag
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
