using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersScript
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareWorkersScriptFilter), fullyQualifiedName: "cloudflare.dataCloudflareWorkersScript.DataCloudflareWorkersScriptFilter")]
    public interface IDataCloudflareWorkersScriptFilter
    {
        /// <summary>Filter scripts by tags. Format: comma-separated list of tag:allowed pairs where allowed is 'yes' or 'no'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/workers_script#tags DataCloudflareWorkersScript#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareWorkersScriptFilter), fullyQualifiedName: "cloudflare.dataCloudflareWorkersScript.DataCloudflareWorkersScriptFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareWorkersScript.IDataCloudflareWorkersScriptFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter scripts by tags. Format: comma-separated list of tag:allowed pairs where allowed is 'yes' or 'no'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/workers_script#tags DataCloudflareWorkersScript#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tags
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
