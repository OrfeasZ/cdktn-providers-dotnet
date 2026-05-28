using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRuleV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2Action")]
    public class SecurityhubAutomationRuleV2Action : aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2Action
    {
        /// <summary>The action type: FINDING_FIELDS_UPDATE or EXTERNAL_INTEGRATION.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_automation_rule_v2#type SecurityhubAutomationRuleV2#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _externalIntegrationConfiguration;

        /// <summary>external_integration_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_automation_rule_v2#external_integration_configuration SecurityhubAutomationRuleV2#external_integration_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalIntegrationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExternalIntegrationConfiguration
        {
            get => _externalIntegrationConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2ActionExternalIntegrationConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _externalIntegrationConfiguration = value;
            }
        }

        private object? _findingFieldsUpdate;

        /// <summary>finding_fields_update block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_automation_rule_v2#finding_fields_update SecurityhubAutomationRuleV2#finding_fields_update}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingFieldsUpdate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRuleV2.SecurityhubAutomationRuleV2ActionFindingFieldsUpdate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingFieldsUpdate
        {
            get => _findingFieldsUpdate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2ActionFindingFieldsUpdate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRuleV2.ISecurityhubAutomationRuleV2ActionFindingFieldsUpdate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingFieldsUpdate = value;
            }
        }
    }
}
