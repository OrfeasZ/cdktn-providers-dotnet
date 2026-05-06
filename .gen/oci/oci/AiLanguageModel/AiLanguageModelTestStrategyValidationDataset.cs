using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDataset")]
    public class AiLanguageModelTestStrategyValidationDataset : oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#dataset_type AiLanguageModel#dataset_type}.</summary>
        [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
        public string DatasetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#dataset_id AiLanguageModel#dataset_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatasetId
        {
            get;
            set;
        }

        /// <summary>location_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#location_details AiLanguageModel#location_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "locationDetails", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDatasetLocationDetails\"}", isOptional: true)]
        public oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDatasetLocationDetails? LocationDetails
        {
            get;
            set;
        }
    }
}
