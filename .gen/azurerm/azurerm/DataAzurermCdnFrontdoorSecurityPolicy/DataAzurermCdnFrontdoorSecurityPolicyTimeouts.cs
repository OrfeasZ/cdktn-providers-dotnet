using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorSecurityPolicy
{
    [JsiiByValue(fqn: "azurerm.dataAzurermCdnFrontdoorSecurityPolicy.DataAzurermCdnFrontdoorSecurityPolicyTimeouts")]
    public class DataAzurermCdnFrontdoorSecurityPolicyTimeouts : azurerm.DataAzurermCdnFrontdoorSecurityPolicy.IDataAzurermCdnFrontdoorSecurityPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/cdn_frontdoor_security_policy#read DataAzurermCdnFrontdoorSecurityPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
