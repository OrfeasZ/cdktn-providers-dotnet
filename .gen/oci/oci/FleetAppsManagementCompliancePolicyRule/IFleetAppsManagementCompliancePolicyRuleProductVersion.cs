using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementCompliancePolicyRule
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementCompliancePolicyRuleProductVersion), fullyQualifiedName: "oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRuleProductVersion")]
    public interface IFleetAppsManagementCompliancePolicyRuleProductVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#version FleetAppsManagementCompliancePolicyRule#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#is_applicable_for_all_higher_versions FleetAppsManagementCompliancePolicyRule#is_applicable_for_all_higher_versions}.</summary>
        [JsiiProperty(name: "isApplicableForAllHigherVersions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsApplicableForAllHigherVersions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementCompliancePolicyRuleProductVersion), fullyQualifiedName: "oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRuleProductVersion")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementCompliancePolicyRule.IFleetAppsManagementCompliancePolicyRuleProductVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#version FleetAppsManagementCompliancePolicyRule#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#is_applicable_for_all_higher_versions FleetAppsManagementCompliancePolicyRule#is_applicable_for_all_higher_versions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isApplicableForAllHigherVersions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsApplicableForAllHigherVersions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
