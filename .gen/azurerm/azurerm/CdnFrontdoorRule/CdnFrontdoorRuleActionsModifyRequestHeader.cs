using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsModifyRequestHeader")]
    public class CdnFrontdoorRuleActionsModifyRequestHeader : azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsModifyRequestHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#header_name CdnFrontdoorRule#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#operator CdnFrontdoorRule#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#header_value CdnFrontdoorRule#header_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderValue
        {
            get;
            set;
        }
    }
}
