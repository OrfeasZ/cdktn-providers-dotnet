using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCollection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponents")]
    public class FleetSoftwareUpdateFsuCollectionComponents : oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponents
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#component_type FleetSoftwareUpdateFsuCollection#component_type}.</summary>
        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComponentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#source_major_version FleetSoftwareUpdateFsuCollection#source_major_version}.</summary>
        [JsiiProperty(name: "sourceMajorVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceMajorVersion
        {
            get;
            set;
        }

        /// <summary>fleet_discovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#fleet_discovery FleetSoftwareUpdateFsuCollection#fleet_discovery}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fleetDiscovery", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery\"}", isOptional: true)]
        public oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery? FleetDiscovery
        {
            get;
            set;
        }
    }
}
