using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirect")]
    public class CdnFrontdoorBatchRuleSetRuleActionsUrlRedirect : azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_batch_rule_set#redirect_type CdnFrontdoorBatchRuleSet#redirect_type}.</summary>
        [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
        public string RedirectType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_fragment CdnFrontdoorBatchRuleSet#destination_fragment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationFragment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_host_name CdnFrontdoorBatchRuleSet#destination_host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationHostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_path CdnFrontdoorBatchRuleSet#destination_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_batch_rule_set#query_string CdnFrontdoorBatchRuleSet#query_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_batch_rule_set#redirect_protocol CdnFrontdoorBatchRuleSet#redirect_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectProtocol
        {
            get;
            set;
        }
    }
}
