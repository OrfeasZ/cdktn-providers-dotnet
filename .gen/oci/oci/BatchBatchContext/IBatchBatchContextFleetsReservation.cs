using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    [JsiiInterface(nativeType: typeof(IBatchBatchContextFleetsReservation), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextFleetsReservation")]
    public interface IBatchBatchContextFleetsReservation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#capacity_reservation_ids BatchBatchContext#capacity_reservation_ids}.</summary>
        [JsiiProperty(name: "capacityReservationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CapacityReservationIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchBatchContextFleetsReservation), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextFleetsReservation")]
        internal sealed class _Proxy : DeputyBase, oci.BatchBatchContext.IBatchBatchContextFleetsReservation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#capacity_reservation_ids BatchBatchContext#capacity_reservation_ids}.</summary>
            [JsiiProperty(name: "capacityReservationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CapacityReservationIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
