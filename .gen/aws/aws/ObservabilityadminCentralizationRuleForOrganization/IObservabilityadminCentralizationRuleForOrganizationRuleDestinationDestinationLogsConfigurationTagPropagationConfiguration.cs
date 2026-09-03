using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration")]
    public interface IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_centralization_rule_for_organization#destination_role_arn ObservabilityadminCentralizationRuleForOrganization#destination_role_arn}.</summary>
        [JsiiProperty(name: "destinationRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_centralization_rule_for_organization#tag_conflict_resolution_strategy ObservabilityadminCentralizationRuleForOrganization#tag_conflict_resolution_strategy}.</summary>
        [JsiiProperty(name: "tagConflictResolutionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagConflictResolutionStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfigurationTagPropagationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_centralization_rule_for_organization#destination_role_arn ObservabilityadminCentralizationRuleForOrganization#destination_role_arn}.</summary>
            [JsiiProperty(name: "destinationRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_centralization_rule_for_organization#tag_conflict_resolution_strategy ObservabilityadminCentralizationRuleForOrganization#tag_conflict_resolution_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagConflictResolutionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagConflictResolutionStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
