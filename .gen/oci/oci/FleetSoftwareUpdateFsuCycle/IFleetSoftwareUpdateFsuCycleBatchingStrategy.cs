using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiInterface(nativeType: typeof(IFleetSoftwareUpdateFsuCycleBatchingStrategy), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategy")]
    public interface IFleetSoftwareUpdateFsuCycleBatchingStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_force_rolling FleetSoftwareUpdateFsuCycle#is_force_rolling}.</summary>
        [JsiiProperty(name: "isForceRolling", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsForceRolling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_wait_for_batch_resume FleetSoftwareUpdateFsuCycle#is_wait_for_batch_resume}.</summary>
        [JsiiProperty(name: "isWaitForBatchResume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsWaitForBatchResume
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#percentage FleetSoftwareUpdateFsuCycle#percentage}.</summary>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Percentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#type FleetSoftwareUpdateFsuCycle#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetSoftwareUpdateFsuCycleBatchingStrategy), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategy")]
        internal sealed class _Proxy : DeputyBase, oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleBatchingStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_force_rolling FleetSoftwareUpdateFsuCycle#is_force_rolling}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isForceRolling", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsForceRolling
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_wait_for_batch_resume FleetSoftwareUpdateFsuCycle#is_wait_for_batch_resume}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isWaitForBatchResume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsWaitForBatchResume
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#percentage FleetSoftwareUpdateFsuCycle#percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Percentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#type FleetSoftwareUpdateFsuCycle#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
