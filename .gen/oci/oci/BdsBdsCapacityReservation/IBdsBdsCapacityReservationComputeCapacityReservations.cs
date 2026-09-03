using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsCapacityReservation
{
    [JsiiInterface(nativeType: typeof(IBdsBdsCapacityReservationComputeCapacityReservations), fullyQualifiedName: "oci.bdsBdsCapacityReservation.BdsBdsCapacityReservationComputeCapacityReservations")]
    public interface IBdsBdsCapacityReservationComputeCapacityReservations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_capacity_reservation#domain1reservation_id BdsBdsCapacityReservation#domain1reservation_id}.</summary>
        [JsiiProperty(name: "domain1ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Domain1ReservationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_capacity_reservation#domain2reservation_id BdsBdsCapacityReservation#domain2reservation_id}.</summary>
        [JsiiProperty(name: "domain2ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Domain2ReservationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_capacity_reservation#domain3reservation_id BdsBdsCapacityReservation#domain3reservation_id}.</summary>
        [JsiiProperty(name: "domain3ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Domain3ReservationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsCapacityReservationComputeCapacityReservations), fullyQualifiedName: "oci.bdsBdsCapacityReservation.BdsBdsCapacityReservationComputeCapacityReservations")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsCapacityReservation.IBdsBdsCapacityReservationComputeCapacityReservations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_capacity_reservation#domain1reservation_id BdsBdsCapacityReservation#domain1reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domain1ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain1ReservationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_capacity_reservation#domain2reservation_id BdsBdsCapacityReservation#domain2reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domain2ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain2ReservationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_capacity_reservation#domain3reservation_id BdsBdsCapacityReservation#domain3reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domain3ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain3ReservationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
