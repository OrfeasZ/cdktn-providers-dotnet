using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuReadinessCheck
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetSoftwareUpdateFsuReadinessCheck.FleetSoftwareUpdateFsuReadinessCheckTargets")]
    public class FleetSoftwareUpdateFsuReadinessCheckTargets : oci.FleetSoftwareUpdateFsuReadinessCheck.IFleetSoftwareUpdateFsuReadinessCheckTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/fleet_software_update_fsu_readiness_check#entity_id FleetSoftwareUpdateFsuReadinessCheck#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        public string EntityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/fleet_software_update_fsu_readiness_check#entity_type FleetSoftwareUpdateFsuReadinessCheck#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        public string EntityType
        {
            get;
            set;
        }
    }
}
