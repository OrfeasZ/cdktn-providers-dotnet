using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageJob
{
    [JsiiByValue(fqn: "oci.aiLanguageJob.AiLanguageJobTimeouts")]
    public class AiLanguageJobTimeouts : oci.AiLanguageJob.IAiLanguageJobTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/ai_language_job#create AiLanguageJob#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/ai_language_job#delete AiLanguageJob#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/ai_language_job#update AiLanguageJob#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
