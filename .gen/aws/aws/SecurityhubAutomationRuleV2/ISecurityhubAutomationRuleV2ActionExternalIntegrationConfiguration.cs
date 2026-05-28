using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRuleV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration), fullyQualifiedName: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration")]
    public interface ISecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration
    {
        /// <summary>The ARN of the connector.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_automation_rule_v2#connector_arn SecurityhubAutomationRuleV2#connector_arn}
        /// </remarks>
        [JsiiProperty(name: "connectorArn", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectorArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration), fullyQualifiedName: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ARN of the connector.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_automation_rule_v2#connector_arn SecurityhubAutomationRuleV2#connector_arn}
            /// </remarks>
            [JsiiProperty(name: "connectorArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectorArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
