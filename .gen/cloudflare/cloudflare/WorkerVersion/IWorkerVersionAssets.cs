using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionAssets), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionAssets")]
    public interface IWorkerVersionAssets
    {
        /// <summary>Configuration for assets within a Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#config WorkerVersion#config}
        /// </remarks>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssetsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionAssetsConfig? Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>Path to the directory containing asset files to upload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#directory WorkerVersion#directory}
        /// </remarks>
        [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Directory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Token provided upon successful upload of all files from a registered manifest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#jwt WorkerVersion#jwt}
        /// </remarks>
        [JsiiProperty(name: "jwt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jwt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionAssets), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionAssets")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionAssets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configuration for assets within a Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#config WorkerVersion#config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssetsConfig\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionAssetsConfig? Config
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionAssetsConfig?>();
            }

            /// <summary>Path to the directory containing asset files to upload.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#directory WorkerVersion#directory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Directory
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Token provided upon successful upload of all files from a registered manifest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#jwt WorkerVersion#jwt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jwt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jwt
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
