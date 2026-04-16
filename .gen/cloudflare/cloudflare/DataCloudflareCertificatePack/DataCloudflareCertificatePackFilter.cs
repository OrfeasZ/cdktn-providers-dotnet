using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCertificatePack
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackFilter")]
    public class DataCloudflareCertificatePackFilter : cloudflare.DataCloudflareCertificatePack.IDataCloudflareCertificatePackFilter
    {
        /// <summary>Specify the deployment environment for the certificate packs. Available values: "staging", "production".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/certificate_pack#deploy DataCloudflareCertificatePack#deploy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Deploy
        {
            get;
            set;
        }

        /// <summary>Include Certificate Packs of all statuses, not just active ones. Available values: "all".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/certificate_pack#status DataCloudflareCertificatePack#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
