using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWebAnalyticsSite
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareWebAnalyticsSiteFilter), fullyQualifiedName: "cloudflare.dataCloudflareWebAnalyticsSite.DataCloudflareWebAnalyticsSiteFilter")]
    public interface IDataCloudflareWebAnalyticsSiteFilter
    {
        /// <summary>The property used to sort the list of results. Available values: "host", "created".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/web_analytics_site#order_by DataCloudflareWebAnalyticsSite#order_by}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareWebAnalyticsSiteFilter), fullyQualifiedName: "cloudflare.dataCloudflareWebAnalyticsSite.DataCloudflareWebAnalyticsSiteFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareWebAnalyticsSite.IDataCloudflareWebAnalyticsSiteFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The property used to sort the list of results. Available values: "host", "created".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/web_analytics_site#order_by DataCloudflareWebAnalyticsSite#order_by}
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
