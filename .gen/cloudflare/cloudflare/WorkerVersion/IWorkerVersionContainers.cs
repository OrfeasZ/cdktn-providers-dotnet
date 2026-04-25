using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionContainers), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionContainers")]
    public interface IWorkerVersionContainers
    {
        /// <summary>Select which Durable Object class should get this container attached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#class_name WorkerVersion#class_name}
        /// </remarks>
        [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}")]
        string ClassName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionContainers), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionContainers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionContainers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Select which Durable Object class should get this container attached.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#class_name WorkerVersion#class_name}
            /// </remarks>
            [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}")]
            public string ClassName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
