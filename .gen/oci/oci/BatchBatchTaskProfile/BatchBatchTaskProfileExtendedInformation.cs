using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchTaskProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.batchBatchTaskProfile.BatchBatchTaskProfileExtendedInformation")]
    public class BatchBatchTaskProfileExtendedInformation : oci.BatchBatchTaskProfile.IBatchBatchTaskProfileExtendedInformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/batch_batch_task_profile#type BatchBatchTaskProfile#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/batch_batch_task_profile#architecture BatchBatchTaskProfile#architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Architecture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/batch_batch_task_profile#shape_name BatchBatchTaskProfile#shape_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShapeName
        {
            get;
            set;
        }
    }
}
