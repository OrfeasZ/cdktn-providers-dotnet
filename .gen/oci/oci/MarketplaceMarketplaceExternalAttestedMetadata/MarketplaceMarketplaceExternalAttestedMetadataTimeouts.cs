using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplaceMarketplaceExternalAttestedMetadata
{
    [JsiiByValue(fqn: "oci.marketplaceMarketplaceExternalAttestedMetadata.MarketplaceMarketplaceExternalAttestedMetadataTimeouts")]
    public class MarketplaceMarketplaceExternalAttestedMetadataTimeouts : oci.MarketplaceMarketplaceExternalAttestedMetadata.IMarketplaceMarketplaceExternalAttestedMetadataTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#create MarketplaceMarketplaceExternalAttestedMetadata#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#delete MarketplaceMarketplaceExternalAttestedMetadata#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#update MarketplaceMarketplaceExternalAttestedMetadata#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
