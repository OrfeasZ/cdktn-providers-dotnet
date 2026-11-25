using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.batchBatchContext.BatchBatchContextFleetsReservation")]
    public class BatchBatchContextFleetsReservation : oci.BatchBatchContext.IBatchBatchContextFleetsReservation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#capacity_reservation_ids BatchBatchContext#capacity_reservation_ids}.</summary>
        [JsiiProperty(name: "capacityReservationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CapacityReservationIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
