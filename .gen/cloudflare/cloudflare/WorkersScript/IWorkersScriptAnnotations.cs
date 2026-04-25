using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptAnnotations), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptAnnotations")]
    public interface IWorkersScriptAnnotations
    {
        /// <summary>Human-readable message about the version. Truncated to 1000 bytes if longer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#workers_message WorkersScript#workers_message}
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

        /// <summary>User-provided identifier for the version. Maximum 100 bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#workers_tag WorkersScript#workers_tag}
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

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptAnnotations), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptAnnotations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptAnnotations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Human-readable message about the version. Truncated to 1000 bytes if longer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#workers_message WorkersScript#workers_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workersMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkersMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-provided identifier for the version. Maximum 100 bytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#workers_tag WorkersScript#workers_tag}
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
