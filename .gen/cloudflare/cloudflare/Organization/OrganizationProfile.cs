using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Organization
{
    [JsiiByValue(fqn: "cloudflare.organization.OrganizationProfile")]
    public class OrganizationProfile : cloudflare.Organization.IOrganizationProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_address Organization#business_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BusinessAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_email Organization#business_email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BusinessEmail
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_name Organization#business_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BusinessName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_phone Organization#business_phone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BusinessPhone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#external_metadata Organization#external_metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalMetadata
        {
            get;
            set;
        }
    }
}
