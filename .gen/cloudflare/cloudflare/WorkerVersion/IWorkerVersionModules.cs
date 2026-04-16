using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionModules), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionModules")]
    public interface IWorkerVersionModules
    {
        /// <summary>The content type of the module.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#content_type WorkerVersion#content_type}
        /// </remarks>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        string ContentType
        {
            get;
        }

        /// <summary>The name of the module.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#name WorkerVersion#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The base64-encoded module content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#content_base64 WorkerVersion#content_base64}
        /// </remarks>
        [JsiiProperty(name: "contentBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentBase64
        {
            get
            {
                return null;
            }
        }

        /// <summary>The file path of the module content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#content_file WorkerVersion#content_file}
        /// </remarks>
        [JsiiProperty(name: "contentFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentFile
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionModules), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionModules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionModules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The content type of the module.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#content_type WorkerVersion#content_type}
            /// </remarks>
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the module.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#name WorkerVersion#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The base64-encoded module content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#content_base64 WorkerVersion#content_base64}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentBase64
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The file path of the module content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#content_file WorkerVersion#content_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentFile
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
