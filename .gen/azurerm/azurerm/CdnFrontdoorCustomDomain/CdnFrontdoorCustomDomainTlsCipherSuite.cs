using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorCustomDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuite")]
    public class CdnFrontdoorCustomDomainTlsCipherSuite : azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_custom_domain#type CdnFrontdoorCustomDomain#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>custom_ciphers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_custom_domain#custom_ciphers CdnFrontdoorCustomDomain#custom_ciphers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customCiphers", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers\"}", isOptional: true)]
        public azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers? CustomCiphers
        {
            get;
            set;
        }
    }
}
