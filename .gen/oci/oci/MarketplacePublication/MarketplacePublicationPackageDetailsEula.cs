using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplacePublication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.marketplacePublication.MarketplacePublicationPackageDetailsEula")]
    public class MarketplacePublicationPackageDetailsEula : oci.MarketplacePublication.IMarketplacePublicationPackageDetailsEula
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#eula_type MarketplacePublication#eula_type}.</summary>
        [JsiiProperty(name: "eulaType", typeJson: "{\"primitive\":\"string\"}")]
        public string EulaType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#license_text MarketplacePublication#license_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseText
        {
            get;
            set;
        }
    }
}
