using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceBdsCapacityReservationConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceBdsCapacityReservationConfigurationTimeouts), fullyQualifiedName: "oci.bdsBdsInstanceBdsCapacityReservationConfiguration.BdsBdsInstanceBdsCapacityReservationConfigurationTimeouts")]
    public interface IBdsBdsInstanceBdsCapacityReservationConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#create BdsBdsInstanceBdsCapacityReservationConfiguration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#delete BdsBdsInstanceBdsCapacityReservationConfiguration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#update BdsBdsInstanceBdsCapacityReservationConfiguration#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceBdsCapacityReservationConfigurationTimeouts), fullyQualifiedName: "oci.bdsBdsInstanceBdsCapacityReservationConfiguration.BdsBdsInstanceBdsCapacityReservationConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceBdsCapacityReservationConfiguration.IBdsBdsInstanceBdsCapacityReservationConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#create BdsBdsInstanceBdsCapacityReservationConfiguration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#delete BdsBdsInstanceBdsCapacityReservationConfiguration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#update BdsBdsInstanceBdsCapacityReservationConfiguration#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
