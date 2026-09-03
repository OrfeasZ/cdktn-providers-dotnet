using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiLanguageJob.AiLanguageJobInputLocation")]
    public class AiLanguageJobInputLocation : oci.AiLanguageJob.IAiLanguageJobInputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ai_language_job#bucket AiLanguageJob#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ai_language_job#location_type AiLanguageJob#location_type}.</summary>
        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        public string LocationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ai_language_job#namespace AiLanguageJob#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/ai_language_job#object_names AiLanguageJob#object_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ObjectNames
        {
            get;
            set;
        }
    }
}
