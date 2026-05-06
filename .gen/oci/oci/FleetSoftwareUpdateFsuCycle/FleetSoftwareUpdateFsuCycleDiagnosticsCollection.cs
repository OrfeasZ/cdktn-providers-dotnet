using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiByValue(fqn: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollection")]
    public class FleetSoftwareUpdateFsuCycleDiagnosticsCollection : oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#log_collection_mode FleetSoftwareUpdateFsuCycle#log_collection_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logCollectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogCollectionMode
        {
            get;
            set;
        }
    }
}
