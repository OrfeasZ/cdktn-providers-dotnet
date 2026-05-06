using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCollection
{
    [JsiiInterface(nativeType: typeof(IFleetSoftwareUpdateFsuCollectionComponents), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponents")]
    public interface IFleetSoftwareUpdateFsuCollectionComponents
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#component_type FleetSoftwareUpdateFsuCollection#component_type}.</summary>
        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        string ComponentType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#source_major_version FleetSoftwareUpdateFsuCollection#source_major_version}.</summary>
        [JsiiProperty(name: "sourceMajorVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SourceMajorVersion
        {
            get;
        }

        /// <summary>fleet_discovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#fleet_discovery FleetSoftwareUpdateFsuCollection#fleet_discovery}
        /// </remarks>
        [JsiiProperty(name: "fleetDiscovery", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery? FleetDiscovery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetSoftwareUpdateFsuCollectionComponents), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponents")]
        internal sealed class _Proxy : DeputyBase, oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponents
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#component_type FleetSoftwareUpdateFsuCollection#component_type}.</summary>
            [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ComponentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#source_major_version FleetSoftwareUpdateFsuCollection#source_major_version}.</summary>
            [JsiiProperty(name: "sourceMajorVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceMajorVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>fleet_discovery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#fleet_discovery FleetSoftwareUpdateFsuCollection#fleet_discovery}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fleetDiscovery", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery\"}", isOptional: true)]
            public oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery? FleetDiscovery
            {
                get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponentsFleetDiscovery?>();
            }
        }
    }
}
