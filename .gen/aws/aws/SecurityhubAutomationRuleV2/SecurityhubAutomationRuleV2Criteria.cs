using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRuleV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2Criteria")]
    public class SecurityhubAutomationRuleV2Criteria : aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2Criteria
    {
        /// <summary>JSON-encoded OCSF finding criteria for the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#ocsf_finding_criteria_json SecurityhubAutomationRuleV2#ocsf_finding_criteria_json}
        /// </remarks>
        [JsiiProperty(name: "ocsfFindingCriteriaJson", typeJson: "{\"primitive\":\"string\"}")]
        public string OcsfFindingCriteriaJson
        {
            get;
            set;
        }
    }
}
