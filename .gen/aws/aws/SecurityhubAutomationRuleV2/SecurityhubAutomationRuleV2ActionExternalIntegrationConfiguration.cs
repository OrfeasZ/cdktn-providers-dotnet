using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRuleV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration")]
    public class SecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration : aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration
    {
        /// <summary>The ARN of the connector.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#connector_arn SecurityhubAutomationRuleV2#connector_arn}
        /// </remarks>
        [JsiiProperty(name: "connectorArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectorArn
        {
            get;
            set;
        }
    }
}
