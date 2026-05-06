using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplacePublication
{
    [JsiiByValue(fqn: "oci.marketplacePublication.MarketplacePublicationSupportContacts")]
    public class MarketplacePublicationSupportContacts : oci.MarketplacePublication.IMarketplacePublicationSupportContacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#email MarketplacePublication#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#name MarketplacePublication#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#phone MarketplacePublication#phone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Phone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#subject MarketplacePublication#subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subject
        {
            get;
            set;
        }
    }
}
