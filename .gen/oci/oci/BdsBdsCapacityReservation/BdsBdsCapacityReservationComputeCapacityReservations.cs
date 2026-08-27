using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsCapacityReservation
{
    [JsiiByValue(fqn: "oci.bdsBdsCapacityReservation.BdsBdsCapacityReservationComputeCapacityReservations")]
    public class BdsBdsCapacityReservationComputeCapacityReservations : oci.BdsBdsCapacityReservation.IBdsBdsCapacityReservationComputeCapacityReservations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_capacity_reservation#domain1reservation_id BdsBdsCapacityReservation#domain1reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain1ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain1ReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_capacity_reservation#domain2reservation_id BdsBdsCapacityReservation#domain2reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain2ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain2ReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_capacity_reservation#domain3reservation_id BdsBdsCapacityReservation#domain3reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain3ReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain3ReservationId
        {
            get;
            set;
        }
    }
}
