using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiVisionStreamJob.AiVisionStreamJobStreamOutputLocation")]
    public class AiVisionStreamJobStreamOutputLocation : oci.AiVisionStreamJob.IAiVisionStreamJobStreamOutputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#bucket AiVisionStreamJob#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#namespace AiVisionStreamJob#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#output_location_type AiVisionStreamJob#output_location_type}.</summary>
        [JsiiProperty(name: "outputLocationType", typeJson: "{\"primitive\":\"string\"}")]
        public string OutputLocationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#prefix AiVisionStreamJob#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_job#obo_token AiVisionStreamJob#obo_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oboToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OboToken
        {
            get;
            set;
        }
    }
}
