using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplacePublication
{
    [JsiiByValue(fqn: "oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystem")]
    public class MarketplacePublicationPackageDetailsOperatingSystem : oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#name MarketplacePublication#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
