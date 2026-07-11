using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileIdentity")]
    public class CdnFrontdoorProfileIdentity : azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_profile#type CdnFrontdoorProfile#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/cdn_frontdoor_profile#identity_ids CdnFrontdoorProfile#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
