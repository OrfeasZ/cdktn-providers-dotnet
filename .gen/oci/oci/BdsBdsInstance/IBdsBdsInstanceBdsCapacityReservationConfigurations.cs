using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceBdsCapacityReservationConfigurations), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceBdsCapacityReservationConfigurations")]
    public interface IBdsBdsInstanceBdsCapacityReservationConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance#bds_capacity_reservation_id BdsBdsInstance#bds_capacity_reservation_id}.</summary>
        [JsiiProperty(name: "bdsCapacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        string BdsCapacityReservationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance#display_name BdsBdsInstance#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceBdsCapacityReservationConfigurations), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceBdsCapacityReservationConfigurations")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstance.IBdsBdsInstanceBdsCapacityReservationConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance#bds_capacity_reservation_id BdsBdsInstance#bds_capacity_reservation_id}.</summary>
            [JsiiProperty(name: "bdsCapacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
            public string BdsCapacityReservationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance#display_name BdsBdsInstance#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
