using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerPreviewsBaseConfigEnv), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigEnv")]
    public interface IWorkerPreviewsBaseConfigEnv
    {
        /// <summary>The kind of resource that the binding provides.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#type Worker#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerPreviewsBaseConfigEnv), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigEnv")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerPreviewsBaseConfigEnv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The kind of resource that the binding provides.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#type Worker#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
