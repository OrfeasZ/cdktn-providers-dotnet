using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRuleV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleV2Action), fullyQualifiedName: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2Action")]
    public interface ISecurityhubAutomationRuleV2Action
    {
        /// <summary>The action type: FINDING_FIELDS_UPDATE or EXTERNAL_INTEGRATION.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#type SecurityhubAutomationRuleV2#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>external_integration_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#external_integration_configuration SecurityhubAutomationRuleV2#external_integration_configuration}
        /// </remarks>
        [JsiiProperty(name: "externalIntegrationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalIntegrationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_fields_update block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#finding_fields_update SecurityhubAutomationRuleV2#finding_fields_update}
        /// </remarks>
        [JsiiProperty(name: "findingFieldsUpdate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionFindingFieldsUpdate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingFieldsUpdate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleV2Action), fullyQualifiedName: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2Action")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2Action
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The action type: FINDING_FIELDS_UPDATE or EXTERNAL_INTEGRATION.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#type SecurityhubAutomationRuleV2#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>external_integration_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#external_integration_configuration SecurityhubAutomationRuleV2#external_integration_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalIntegrationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExternalIntegrationConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_fields_update block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_automation_rule_v2#finding_fields_update SecurityhubAutomationRuleV2#finding_fields_update}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingFieldsUpdate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionFindingFieldsUpdate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingFieldsUpdate
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
