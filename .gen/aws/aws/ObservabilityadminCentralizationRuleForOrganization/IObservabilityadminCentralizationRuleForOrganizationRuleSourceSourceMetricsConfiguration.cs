using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminCentralizationRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration")]
    public interface IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_centralization_rule_for_organization#metrics_selection_criteria ObservabilityadminCentralizationRuleForOrganization#metrics_selection_criteria}.</summary>
        [JsiiProperty(name: "metricsSelectionCriteria", typeJson: "{\"primitive\":\"string\"}")]
        string MetricsSelectionCriteria
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration), fullyQualifiedName: "aws.observabilityadminCentralizationRuleForOrganization.ObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminCentralizationRuleForOrganization.IObservabilityadminCentralizationRuleForOrganizationRuleSourceSourceMetricsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/observabilityadmin_centralization_rule_for_organization#metrics_selection_criteria ObservabilityadminCentralizationRuleForOrganization#metrics_selection_criteria}.</summary>
            [JsiiProperty(name: "metricsSelectionCriteria", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricsSelectionCriteria
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
