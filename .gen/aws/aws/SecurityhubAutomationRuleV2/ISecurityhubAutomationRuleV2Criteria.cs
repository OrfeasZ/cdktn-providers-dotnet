using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRuleV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleV2Criteria), fullyQualifiedName: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2Criteria")]
    public interface ISecurityhubAutomationRuleV2Criteria
    {
        /// <summary>JSON-encoded OCSF finding criteria for the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_automation_rule_v2#ocsf_finding_criteria_json SecurityhubAutomationRuleV2#ocsf_finding_criteria_json}
        /// </remarks>
        [JsiiProperty(name: "ocsfFindingCriteriaJson", typeJson: "{\"primitive\":\"string\"}")]
        string OcsfFindingCriteriaJson
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleV2Criteria), fullyQualifiedName: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2Criteria")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2Criteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>JSON-encoded OCSF finding criteria for the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_automation_rule_v2#ocsf_finding_criteria_json SecurityhubAutomationRuleV2#ocsf_finding_criteria_json}
            /// </remarks>
            [JsiiProperty(name: "ocsfFindingCriteriaJson", typeJson: "{\"primitive\":\"string\"}")]
            public string OcsfFindingCriteriaJson
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
