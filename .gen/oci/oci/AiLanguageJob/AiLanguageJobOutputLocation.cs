using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiLanguageJob.AiLanguageJobOutputLocation")]
    public class AiLanguageJobOutputLocation : oci.AiLanguageJob.IAiLanguageJobOutputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ai_language_job#bucket AiLanguageJob#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ai_language_job#namespace AiLanguageJob#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ai_language_job#prefix AiLanguageJob#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
