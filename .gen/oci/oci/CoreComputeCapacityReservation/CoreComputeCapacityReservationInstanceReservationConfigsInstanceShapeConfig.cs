using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReservation
{
    [JsiiByValue(fqn: "oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig")]
    public class CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig : oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#memory_in_gbs CoreComputeCapacityReservation#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_capacity_reservation#ocpus CoreComputeCapacityReservation#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }
    }
}
