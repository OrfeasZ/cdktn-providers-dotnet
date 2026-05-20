using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRuleV2
{
    [JsiiByValue(fqn: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionFindingFieldsUpdate")]
    public class SecurityhubAutomationRuleV2ActionFindingFieldsUpdate : aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2ActionFindingFieldsUpdate
    {
        /// <summary>A comment for the finding.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#comment SecurityhubAutomationRuleV2#comment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comment
        {
            get;
            set;
        }

        /// <summary>The severity ID to assign.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#severity_id SecurityhubAutomationRuleV2#severity_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "severityId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SeverityId
        {
            get;
            set;
        }

        /// <summary>The status ID to assign.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#status_id SecurityhubAutomationRuleV2#status_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StatusId
        {
            get;
            set;
        }
    }
}
