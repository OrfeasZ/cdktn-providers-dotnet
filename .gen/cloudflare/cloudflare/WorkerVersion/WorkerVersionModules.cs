using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionModules")]
    public class WorkerVersionModules : cloudflare.WorkerVersion.IWorkerVersionModules
    {
        /// <summary>The content type of the module.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#content_type WorkerVersion#content_type}
        /// </remarks>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>The name of the module.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#name WorkerVersion#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The base64-encoded module content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#content_base64 WorkerVersion#content_base64}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentBase64
        {
            get;
            set;
        }

        /// <summary>The file path of the module content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#content_file WorkerVersion#content_file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentFile
        {
            get;
            set;
        }
    }
}
