using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiInterface(nativeType: typeof(IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails")]
    public interface IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_software_image_id FleetSoftwareUpdateFsuCycle#goal_software_image_id}.</summary>
        [JsiiProperty(name: "goalSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        string GoalSoftwareImageId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_type FleetSoftwareUpdateFsuCycle#goal_type}.</summary>
        [JsiiProperty(name: "goalType", typeJson: "{\"primitive\":\"string\"}")]
        string GoalType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_version FleetSoftwareUpdateFsuCycle#goal_version}.</summary>
        [JsiiProperty(name: "goalVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GoalVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetailsComponentsGoalVersionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_software_image_id FleetSoftwareUpdateFsuCycle#goal_software_image_id}.</summary>
            [JsiiProperty(name: "goalSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
            public string GoalSoftwareImageId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_type FleetSoftwareUpdateFsuCycle#goal_type}.</summary>
            [JsiiProperty(name: "goalType", typeJson: "{\"primitive\":\"string\"}")]
            public string GoalType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_version FleetSoftwareUpdateFsuCycle#goal_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "goalVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GoalVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
