using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleDestination), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestination")]
    public interface IObservabilityadminCentralizationRuleForOrganizationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#account ObservabilityadminCentralizationRuleForOrganization#account}.</summary>
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}")]
        string Account
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#region ObservabilityadminCentralizationRuleForOrganization#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>destination_logs_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#destination_logs_configuration ObservabilityadminCentralizationRuleForOrganization#destination_logs_configuration}
        /// </remarks>
        [JsiiProperty(name: "destinationLogsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DestinationLogsConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleDestination), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestination")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#account ObservabilityadminCentralizationRuleForOrganization#account}.</summary>
            [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}")]
            public string Account
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#region ObservabilityadminCentralizationRuleForOrganization#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destination_logs_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_centralization_rule_for_organization#destination_logs_configuration ObservabilityadminCentralizationRuleForOrganization#destination_logs_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationLogsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleDestinationDestinationLogsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DestinationLogsConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
