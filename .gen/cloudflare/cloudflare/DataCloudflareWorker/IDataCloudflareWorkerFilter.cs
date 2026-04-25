using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorker
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareWorkerFilter), fullyQualifiedName: "cloudflare.dataCloudflareWorker.DataCloudflareWorkerFilter")]
    public interface IDataCloudflareWorkerFilter
    {
        /// <summary>Sort direction. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker#order DataCloudflareWorker#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        /// <summary>Property to sort results by. Available values: "deployed_on", "updated_on", "created_on", "name".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker#order_by DataCloudflareWorker#order_by}
        /// </remarks>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrderBy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareWorkerFilter), fullyQualifiedName: "cloudflare.dataCloudflareWorker.DataCloudflareWorkerFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareWorker.IDataCloudflareWorkerFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sort direction. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker#order DataCloudflareWorker#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Property to sort results by. Available values: "deployed_on", "updated_on", "created_on", "name".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker#order_by DataCloudflareWorker#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
