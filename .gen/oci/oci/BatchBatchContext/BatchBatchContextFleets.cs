using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.batchBatchContext.BatchBatchContextFleets")]
    public class BatchBatchContextFleets : oci.BatchBatchContext.IBatchBatchContextFleets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_context#max_concurrent_tasks BatchBatchContext#max_concurrent_tasks}.</summary>
        [JsiiProperty(name: "maxConcurrentTasks", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxConcurrentTasks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_context#name BatchBatchContext#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>shape block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_context#shape BatchBatchContext#shape}
        /// </remarks>
        [JsiiProperty(name: "shape", typeJson: "{\"fqn\":\"oci.batchBatchContext.BatchBatchContextFleetsShape\"}")]
        public oci.BatchBatchContext.IBatchBatchContextFleetsShape Shape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
