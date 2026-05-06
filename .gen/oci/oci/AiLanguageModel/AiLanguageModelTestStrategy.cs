using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiLanguageModel.AiLanguageModelTestStrategy")]
    public class AiLanguageModelTestStrategy : oci.AiLanguageModel.IAiLanguageModelTestStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#strategy_type AiLanguageModel#strategy_type}.</summary>
        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        public string StrategyType
        {
            get;
            set;
        }

        /// <summary>testing_dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#testing_dataset AiLanguageModel#testing_dataset}
        /// </remarks>
        [JsiiProperty(name: "testingDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDataset\"}")]
        public oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset TestingDataset
        {
            get;
            set;
        }

        /// <summary>validation_dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#validation_dataset AiLanguageModel#validation_dataset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validationDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDataset\"}", isOptional: true)]
        public oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset? ValidationDataset
        {
            get;
            set;
        }
    }
}
