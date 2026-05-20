using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRuleV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleV2ActionFindingFieldsUpdate), fullyQualifiedName: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionFindingFieldsUpdate")]
    public interface ISecurityhubAutomationRuleV2ActionFindingFieldsUpdate
    {
        /// <summary>A comment for the finding.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#comment SecurityhubAutomationRuleV2#comment}
        /// </remarks>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>The severity ID to assign.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#severity_id SecurityhubAutomationRuleV2#severity_id}
        /// </remarks>
        [JsiiProperty(name: "severityId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SeverityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The status ID to assign.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#status_id SecurityhubAutomationRuleV2#status_id}
        /// </remarks>
        [JsiiProperty(name: "statusId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StatusId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleV2ActionFindingFieldsUpdate), fullyQualifiedName: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionFindingFieldsUpdate")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2ActionFindingFieldsUpdate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A comment for the finding.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#comment SecurityhubAutomationRuleV2#comment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The severity ID to assign.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#severity_id SecurityhubAutomationRuleV2#severity_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "severityId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SeverityId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The status ID to assign.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#status_id SecurityhubAutomationRuleV2#status_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StatusId
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
