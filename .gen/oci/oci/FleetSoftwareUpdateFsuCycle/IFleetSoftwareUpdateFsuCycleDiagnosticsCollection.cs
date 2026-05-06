using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiInterface(nativeType: typeof(IFleetSoftwareUpdateFsuCycleDiagnosticsCollection), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollection")]
    public interface IFleetSoftwareUpdateFsuCycleDiagnosticsCollection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#log_collection_mode FleetSoftwareUpdateFsuCycle#log_collection_mode}.</summary>
        [JsiiProperty(name: "logCollectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogCollectionMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetSoftwareUpdateFsuCycleDiagnosticsCollection), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollection")]
        internal sealed class _Proxy : DeputyBase, oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#log_collection_mode FleetSoftwareUpdateFsuCycle#log_collection_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logCollectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogCollectionMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
