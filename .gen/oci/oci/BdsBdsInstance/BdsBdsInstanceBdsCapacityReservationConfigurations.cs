using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bdsBdsInstance.BdsBdsInstanceBdsCapacityReservationConfigurations")]
    public class BdsBdsInstanceBdsCapacityReservationConfigurations : oci.BdsBdsInstance.IBdsBdsInstanceBdsCapacityReservationConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance#bds_capacity_reservation_id BdsBdsInstance#bds_capacity_reservation_id}.</summary>
        [JsiiProperty(name: "bdsCapacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public string BdsCapacityReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance#display_name BdsBdsInstance#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }
    }
}
