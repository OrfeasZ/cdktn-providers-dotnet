using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuReadinessCheck
{
    [JsiiInterface(nativeType: typeof(IFleetSoftwareUpdateFsuReadinessCheckTimeouts), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuReadinessCheck.FleetSoftwareUpdateFsuReadinessCheckTimeouts")]
    public interface IFleetSoftwareUpdateFsuReadinessCheckTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/fleet_software_update_fsu_readiness_check#create FleetSoftwareUpdateFsuReadinessCheck#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/fleet_software_update_fsu_readiness_check#delete FleetSoftwareUpdateFsuReadinessCheck#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/fleet_software_update_fsu_readiness_check#update FleetSoftwareUpdateFsuReadinessCheck#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetSoftwareUpdateFsuReadinessCheckTimeouts), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuReadinessCheck.FleetSoftwareUpdateFsuReadinessCheckTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.FleetSoftwareUpdateFsuReadinessCheck.IFleetSoftwareUpdateFsuReadinessCheckTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/fleet_software_update_fsu_readiness_check#create FleetSoftwareUpdateFsuReadinessCheck#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/fleet_software_update_fsu_readiness_check#delete FleetSoftwareUpdateFsuReadinessCheck#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/fleet_software_update_fsu_readiness_check#update FleetSoftwareUpdateFsuReadinessCheck#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
