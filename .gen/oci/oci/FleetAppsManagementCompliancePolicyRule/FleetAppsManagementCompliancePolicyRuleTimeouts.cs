using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementCompliancePolicyRule
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRuleTimeouts")]
    public class FleetAppsManagementCompliancePolicyRuleTimeouts : oci.FleetAppsManagementCompliancePolicyRule.IFleetAppsManagementCompliancePolicyRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#create FleetAppsManagementCompliancePolicyRule#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#delete FleetAppsManagementCompliancePolicyRule#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#update FleetAppsManagementCompliancePolicyRule#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
