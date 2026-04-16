using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionMigrationsTransferredClasses), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionMigrationsTransferredClasses")]
    public interface IWorkerVersionMigrationsTransferredClasses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#from WorkerVersion#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? From
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#from_script WorkerVersion#from_script}.</summary>
        [JsiiProperty(name: "fromScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FromScript
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#to WorkerVersion#to}.</summary>
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? To
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionMigrationsTransferredClasses), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionMigrationsTransferredClasses")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionMigrationsTransferredClasses
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#from WorkerVersion#from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? From
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#from_script WorkerVersion#from_script}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fromScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FromScript
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#to WorkerVersion#to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? To
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
