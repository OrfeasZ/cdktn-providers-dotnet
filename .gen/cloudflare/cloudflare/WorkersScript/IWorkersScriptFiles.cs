using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptFiles), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptFiles")]
    public interface IWorkersScriptFiles
    {
        /// <summary>Content type of the file, such as `application/wasm`, `text/plain`, or `application/octet-stream`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_type WorkersScript#content_type}
        /// </remarks>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        string ContentType
        {
            get;
        }

        /// <summary>Base64-encoded file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_base64 WorkersScript#content_base64}
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

        /// <summary>Path to the file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_file WorkersScript#content_file}
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

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptFiles), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptFiles")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptFiles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Content type of the file, such as `application/wasm`, `text/plain`, or `application/octet-stream`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_type WorkersScript#content_type}
            /// </remarks>
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Base64-encoded file content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_base64 WorkersScript#content_base64}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentBase64
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Path to the file content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workers_script#content_file WorkersScript#content_file}
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
