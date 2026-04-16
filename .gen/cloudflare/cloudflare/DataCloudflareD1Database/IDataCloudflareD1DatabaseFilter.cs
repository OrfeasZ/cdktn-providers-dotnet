using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareD1Database
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareD1DatabaseFilter), fullyQualifiedName: "cloudflare.dataCloudflareD1Database.DataCloudflareD1DatabaseFilter")]
    public interface IDataCloudflareD1DatabaseFilter
    {
        /// <summary>a database name to search for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/d1_database#name DataCloudflareD1Database#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareD1DatabaseFilter), fullyQualifiedName: "cloudflare.dataCloudflareD1Database.DataCloudflareD1DatabaseFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareD1Database.IDataCloudflareD1DatabaseFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>a database name to search for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/d1_database#name DataCloudflareD1Database#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
