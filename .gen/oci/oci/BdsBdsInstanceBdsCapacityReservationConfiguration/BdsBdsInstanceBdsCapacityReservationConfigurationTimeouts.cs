using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceBdsCapacityReservationConfiguration
{
    [JsiiByValue(fqn: "oci.bdsBdsInstanceBdsCapacityReservationConfiguration.BdsBdsInstanceBdsCapacityReservationConfigurationTimeouts")]
    public class BdsBdsInstanceBdsCapacityReservationConfigurationTimeouts : oci.BdsBdsInstanceBdsCapacityReservationConfiguration.IBdsBdsInstanceBdsCapacityReservationConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#create BdsBdsInstanceBdsCapacityReservationConfiguration#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#delete BdsBdsInstanceBdsCapacityReservationConfiguration#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#update BdsBdsInstanceBdsCapacityReservationConfiguration#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
