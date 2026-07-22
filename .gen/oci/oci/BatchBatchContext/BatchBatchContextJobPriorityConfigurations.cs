using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.batchBatchContext.BatchBatchContextJobPriorityConfigurations")]
    public class BatchBatchContextJobPriorityConfigurations : oci.BatchBatchContext.IBatchBatchContextJobPriorityConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/batch_batch_context#tag_key BatchBatchContext#tag_key}.</summary>
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
        public string TagKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/batch_batch_context#tag_namespace BatchBatchContext#tag_namespace}.</summary>
        [JsiiProperty(name: "tagNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public string TagNamespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/batch_batch_context#values BatchBatchContext#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Values
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/batch_batch_context#weight BatchBatchContext#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public double Weight
        {
            get;
            set;
        }
    }
}
