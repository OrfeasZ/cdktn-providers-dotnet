using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkflow
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareWorkflowFilter), fullyQualifiedName: "cloudflare.dataCloudflareWorkflow.DataCloudflareWorkflowFilter")]
    public interface IDataCloudflareWorkflowFilter
    {
        /// <summary>Allows filtering workflows` name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/workflow#search DataCloudflareWorkflow#search}
        /// </remarks>
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Search
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareWorkflowFilter), fullyQualifiedName: "cloudflare.dataCloudflareWorkflow.DataCloudflareWorkflowFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareWorkflow.IDataCloudflareWorkflowFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allows filtering workflows` name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/workflow#search DataCloudflareWorkflow#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
