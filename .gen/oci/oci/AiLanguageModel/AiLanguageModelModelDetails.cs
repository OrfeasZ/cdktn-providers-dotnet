using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiLanguageModel.AiLanguageModelModelDetails")]
    public class AiLanguageModelModelDetails : oci.AiLanguageModel.IAiLanguageModelModelDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#model_type AiLanguageModel#model_type}.</summary>
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelType
        {
            get;
            set;
        }

        /// <summary>classification_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#classification_mode AiLanguageModel#classification_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "classificationMode", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationMode\"}", isOptional: true)]
        public oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode? ClassificationMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#language_code AiLanguageModel#language_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LanguageCode
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
