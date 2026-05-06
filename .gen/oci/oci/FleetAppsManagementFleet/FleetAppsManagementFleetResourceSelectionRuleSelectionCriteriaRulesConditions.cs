using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRulesConditions")]
    public class FleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRulesConditions : oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRulesConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#attr_group FleetAppsManagementFleet#attr_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attrGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AttrGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#attr_key FleetAppsManagementFleet#attr_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attrKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AttrKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#attr_value FleetAppsManagementFleet#attr_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attrValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AttrValue
        {
            get;
            set;
        }
    }
}
