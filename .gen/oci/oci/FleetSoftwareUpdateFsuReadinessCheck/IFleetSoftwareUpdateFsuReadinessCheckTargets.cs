using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuReadinessCheck
{
    [JsiiInterface(nativeType: typeof(IFleetSoftwareUpdateFsuReadinessCheckTargets), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuReadinessCheck.FleetSoftwareUpdateFsuReadinessCheckTargets")]
    public interface IFleetSoftwareUpdateFsuReadinessCheckTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/fleet_software_update_fsu_readiness_check#entity_id FleetSoftwareUpdateFsuReadinessCheck#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        string EntityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/fleet_software_update_fsu_readiness_check#entity_type FleetSoftwareUpdateFsuReadinessCheck#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        string EntityType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetSoftwareUpdateFsuReadinessCheckTargets), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuReadinessCheck.FleetSoftwareUpdateFsuReadinessCheckTargets")]
        internal sealed class _Proxy : DeputyBase, oci.FleetSoftwareUpdateFsuReadinessCheck.IFleetSoftwareUpdateFsuReadinessCheckTargets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/fleet_software_update_fsu_readiness_check#entity_id FleetSoftwareUpdateFsuReadinessCheck#entity_id}.</summary>
            [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/fleet_software_update_fsu_readiness_check#entity_type FleetSoftwareUpdateFsuReadinessCheck#entity_type}.</summary>
            [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
