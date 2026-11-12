using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2DataCatalog
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.r2DataCatalog.R2DataCatalogCredential")]
    public class R2DataCatalogCredential : cloudflare.R2DataCatalog.IR2DataCatalogCredential
    {
        /// <summary>Provides the Cloudflare API token for accessing R2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/r2_data_catalog#token R2DataCatalog#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }
    }
}
