using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Organization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.organization.OrganizationProfile")]
    public class OrganizationProfile : cloudflare.Organization.IOrganizationProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/organization#business_address Organization#business_address}.</summary>
        [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string BusinessAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/organization#business_email Organization#business_email}.</summary>
        [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}")]
        public string BusinessEmail
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/organization#business_name Organization#business_name}.</summary>
        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}")]
        public string BusinessName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/organization#business_phone Organization#business_phone}.</summary>
        [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}")]
        public string BusinessPhone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/organization#external_metadata Organization#external_metadata}.</summary>
        [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalMetadata
        {
            get;
            set;
        }
    }
}
