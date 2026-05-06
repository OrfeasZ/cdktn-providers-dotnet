using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiModel.GenerativeAiModelFineTuneDetails")]
    public class GenerativeAiModelFineTuneDetails : oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#dedicated_ai_cluster_id GenerativeAiModel#dedicated_ai_cluster_id}.</summary>
        [JsiiProperty(name: "dedicatedAiClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string DedicatedAiClusterId
        {
            get;
            set;
        }

        /// <summary>training_dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#training_dataset GenerativeAiModel#training_dataset}
        /// </remarks>
        [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDataset\"}")]
        public oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset TrainingDataset
        {
            get;
            set;
        }

        /// <summary>training_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#training_config GenerativeAiModel#training_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trainingConfig", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfig\"}", isOptional: true)]
        public oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig? TrainingConfig
        {
            get;
            set;
        }
    }
}
