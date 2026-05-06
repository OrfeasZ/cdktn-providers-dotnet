using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementCompliancePolicyRule
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementCompliancePolicyRulePatchSelection), fullyQualifiedName: "oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRulePatchSelection")]
    public interface IFleetAppsManagementCompliancePolicyRulePatchSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#selection_type FleetAppsManagementCompliancePolicyRule#selection_type}.</summary>
        [JsiiProperty(name: "selectionType", typeJson: "{\"primitive\":\"string\"}")]
        string SelectionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#days_since_release FleetAppsManagementCompliancePolicyRule#days_since_release}.</summary>
        [JsiiProperty(name: "daysSinceRelease", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DaysSinceRelease
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#patch_level FleetAppsManagementCompliancePolicyRule#patch_level}.</summary>
        [JsiiProperty(name: "patchLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatchLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#patch_name FleetAppsManagementCompliancePolicyRule#patch_name}.</summary>
        [JsiiProperty(name: "patchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatchName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementCompliancePolicyRulePatchSelection), fullyQualifiedName: "oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRulePatchSelection")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementCompliancePolicyRule.IFleetAppsManagementCompliancePolicyRulePatchSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#selection_type FleetAppsManagementCompliancePolicyRule#selection_type}.</summary>
            [JsiiProperty(name: "selectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string SelectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#days_since_release FleetAppsManagementCompliancePolicyRule#days_since_release}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "daysSinceRelease", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DaysSinceRelease
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#patch_level FleetAppsManagementCompliancePolicyRule#patch_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patchLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatchLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#patch_name FleetAppsManagementCompliancePolicyRule#patch_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatchName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
