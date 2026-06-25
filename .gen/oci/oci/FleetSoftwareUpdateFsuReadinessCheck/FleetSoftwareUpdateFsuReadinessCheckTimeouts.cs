using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuReadinessCheck
{
    [JsiiByValue(fqn: "oci.fleetSoftwareUpdateFsuReadinessCheck.FleetSoftwareUpdateFsuReadinessCheckTimeouts")]
    public class FleetSoftwareUpdateFsuReadinessCheckTimeouts : oci.FleetSoftwareUpdateFsuReadinessCheck.IFleetSoftwareUpdateFsuReadinessCheckTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_software_update_fsu_readiness_check#create FleetSoftwareUpdateFsuReadinessCheck#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_software_update_fsu_readiness_check#delete FleetSoftwareUpdateFsuReadinessCheck#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_software_update_fsu_readiness_check#update FleetSoftwareUpdateFsuReadinessCheck#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
