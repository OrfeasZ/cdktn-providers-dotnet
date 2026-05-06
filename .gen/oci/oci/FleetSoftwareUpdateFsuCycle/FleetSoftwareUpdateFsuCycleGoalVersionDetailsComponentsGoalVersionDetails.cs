using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails")]
    public class FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails : oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_software_image_id FleetSoftwareUpdateFsuCycle#goal_software_image_id}.</summary>
        [JsiiProperty(name: "goalSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public string GoalSoftwareImageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_type FleetSoftwareUpdateFsuCycle#goal_type}.</summary>
        [JsiiProperty(name: "goalType", typeJson: "{\"primitive\":\"string\"}")]
        public string GoalType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_version FleetSoftwareUpdateFsuCycle#goal_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "goalVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GoalVersion
        {
            get;
            set;
        }
    }
}
