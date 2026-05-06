using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementCompliancePolicyRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRulePatchSelection")]
    public class FleetAppsManagementCompliancePolicyRulePatchSelection : oci.FleetAppsManagementCompliancePolicyRule.IFleetAppsManagementCompliancePolicyRulePatchSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#selection_type FleetAppsManagementCompliancePolicyRule#selection_type}.</summary>
        [JsiiProperty(name: "selectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string SelectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#days_since_release FleetAppsManagementCompliancePolicyRule#days_since_release}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysSinceRelease", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DaysSinceRelease
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#patch_level FleetAppsManagementCompliancePolicyRule#patch_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patchLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PatchLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#patch_name FleetAppsManagementCompliancePolicyRule#patch_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PatchName
        {
            get;
            set;
        }
    }
}
