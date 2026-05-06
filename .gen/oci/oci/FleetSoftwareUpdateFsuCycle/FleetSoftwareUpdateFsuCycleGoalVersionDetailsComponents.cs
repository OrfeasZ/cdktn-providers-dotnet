using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponents")]
    public class FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponents : oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponents
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#component_type FleetSoftwareUpdateFsuCycle#component_type}.</summary>
        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComponentType
        {
            get;
            set;
        }

        /// <summary>goal_version_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_version_details FleetSoftwareUpdateFsuCycle#goal_version_details}
        /// </remarks>
        [JsiiProperty(name: "goalVersionDetails", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails\"}")]
        public oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails GoalVersionDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#home_policy FleetSoftwareUpdateFsuCycle#home_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "homePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HomePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#new_home_prefix FleetSoftwareUpdateFsuCycle#new_home_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "newHomePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NewHomePrefix
        {
            get;
            set;
        }
    }
}
