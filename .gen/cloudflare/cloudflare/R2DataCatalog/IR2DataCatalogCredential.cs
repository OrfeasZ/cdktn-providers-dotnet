using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2DataCatalog
{
    [JsiiInterface(nativeType: typeof(IR2DataCatalogCredential), fullyQualifiedName: "cloudflare.r2DataCatalog.R2DataCatalogCredential")]
    public interface IR2DataCatalogCredential
    {
        /// <summary>Provides the Cloudflare API token for accessing R2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/r2_data_catalog#token R2DataCatalog#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IR2DataCatalogCredential), fullyQualifiedName: "cloudflare.r2DataCatalog.R2DataCatalogCredential")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2DataCatalog.IR2DataCatalogCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Provides the Cloudflare API token for accessing R2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/r2_data_catalog#token R2DataCatalog#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
