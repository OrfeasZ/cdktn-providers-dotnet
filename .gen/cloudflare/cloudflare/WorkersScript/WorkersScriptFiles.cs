using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptFiles")]
    public class WorkersScriptFiles : cloudflare.WorkersScript.IWorkersScriptFiles
    {
        /// <summary>Content type of the file, such as `application/wasm`, `text/plain`, or `application/octet-stream`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_type WorkersScript#content_type}
        /// </remarks>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>Base64-encoded file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_base64 WorkersScript#content_base64}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentBase64
        {
            get;
            set;
        }

        /// <summary>Path to the file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_file WorkersScript#content_file}
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
