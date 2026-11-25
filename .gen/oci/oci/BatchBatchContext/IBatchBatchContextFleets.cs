using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    [JsiiInterface(nativeType: typeof(IBatchBatchContextFleets), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextFleets")]
    public interface IBatchBatchContextFleets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#max_concurrent_tasks BatchBatchContext#max_concurrent_tasks}.</summary>
        [JsiiProperty(name: "maxConcurrentTasks", typeJson: "{\"primitive\":\"number\"}")]
        double MaxConcurrentTasks
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#name BatchBatchContext#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>shape block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#shape BatchBatchContext#shape}
        /// </remarks>
        [JsiiProperty(name: "shape", typeJson: "{\"fqn\":\"oci.batchBatchContext.BatchBatchContextFleetsShape\"}")]
        oci.BatchBatchContext.IBatchBatchContextFleetsShape Shape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>reservation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#reservation BatchBatchContext#reservation}
        /// </remarks>
        [JsiiProperty(name: "reservation", typeJson: "{\"fqn\":\"oci.batchBatchContext.BatchBatchContextFleetsReservation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BatchBatchContext.IBatchBatchContextFleetsReservation? Reservation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchBatchContextFleets), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextFleets")]
        internal sealed class _Proxy : DeputyBase, oci.BatchBatchContext.IBatchBatchContextFleets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#max_concurrent_tasks BatchBatchContext#max_concurrent_tasks}.</summary>
            [JsiiProperty(name: "maxConcurrentTasks", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxConcurrentTasks
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#name BatchBatchContext#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>shape block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#shape BatchBatchContext#shape}
            /// </remarks>
            [JsiiProperty(name: "shape", typeJson: "{\"fqn\":\"oci.batchBatchContext.BatchBatchContextFleetsShape\"}")]
            public oci.BatchBatchContext.IBatchBatchContextFleetsShape Shape
            {
                get => GetInstanceProperty<oci.BatchBatchContext.IBatchBatchContextFleetsShape>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>reservation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/batch_batch_context#reservation BatchBatchContext#reservation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reservation", typeJson: "{\"fqn\":\"oci.batchBatchContext.BatchBatchContextFleetsReservation\"}", isOptional: true)]
            public oci.BatchBatchContext.IBatchBatchContextFleetsReservation? Reservation
            {
                get => GetInstanceProperty<oci.BatchBatchContext.IBatchBatchContextFleetsReservation?>();
            }
        }
    }
}
