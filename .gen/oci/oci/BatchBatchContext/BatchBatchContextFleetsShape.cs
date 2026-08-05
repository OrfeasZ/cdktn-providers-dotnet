using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.batchBatchContext.BatchBatchContextFleetsShape")]
    public class BatchBatchContextFleetsShape : oci.BatchBatchContext.IBatchBatchContextFleetsShape
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/batch_batch_context#memory_in_gbs BatchBatchContext#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/batch_batch_context#ocpus BatchBatchContext#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public double Ocpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/batch_batch_context#disk_size_in_gbs BatchBatchContext#disk_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskSizeInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/batch_batch_context#shape_name BatchBatchContext#shape_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShapeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
