using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerPreviewsBaseConfigTailConsumers), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigTailConsumers")]
    public interface IWorkerPreviewsBaseConfigTailConsumers
    {
        /// <summary>Name of the consumer Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#name Worker#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerPreviewsBaseConfigTailConsumers), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigTailConsumers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the consumer Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#name Worker#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
