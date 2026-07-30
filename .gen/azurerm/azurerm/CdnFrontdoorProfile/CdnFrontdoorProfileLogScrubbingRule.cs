using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileLogScrubbingRule")]
    public class CdnFrontdoorProfileLogScrubbingRule : azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileLogScrubbingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_profile#match_variable CdnFrontdoorProfile#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchVariable
        {
            get;
            set;
        }
    }
}
