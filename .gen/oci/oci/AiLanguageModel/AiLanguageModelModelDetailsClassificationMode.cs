using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationMode")]
    public class AiLanguageModelModelDetailsClassificationMode : oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#classification_mode AiLanguageModel#classification_mode}.</summary>
        [JsiiProperty(name: "classificationMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ClassificationMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#version AiLanguageModel#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
