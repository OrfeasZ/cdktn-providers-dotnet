using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfig")]
    public class GenerativeAiModelFineTuneDetailsTrainingConfig : oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#training_config_type GenerativeAiModel#training_config_type}.</summary>
        [JsiiProperty(name: "trainingConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public string TrainingConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#early_stopping_patience GenerativeAiModel#early_stopping_patience}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "earlyStoppingPatience", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EarlyStoppingPatience
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#early_stopping_threshold GenerativeAiModel#early_stopping_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "earlyStoppingThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EarlyStoppingThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#learning_rate GenerativeAiModel#learning_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "learningRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LearningRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#log_model_metrics_interval_in_steps GenerativeAiModel#log_model_metrics_interval_in_steps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logModelMetricsIntervalInSteps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LogModelMetricsIntervalInSteps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#lora_alpha GenerativeAiModel#lora_alpha}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loraAlpha", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoraAlpha
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#lora_dropout GenerativeAiModel#lora_dropout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loraDropout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoraDropout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#lora_r GenerativeAiModel#lora_r}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loraR", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoraR
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#num_of_last_layers GenerativeAiModel#num_of_last_layers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numOfLastLayers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumOfLastLayers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#total_training_epochs GenerativeAiModel#total_training_epochs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "totalTrainingEpochs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TotalTrainingEpochs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#training_batch_size GenerativeAiModel#training_batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingBatchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TrainingBatchSize
        {
            get;
            set;
        }
    }
}
