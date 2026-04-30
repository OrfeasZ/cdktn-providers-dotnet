using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobExperimentConfig")]
    public class SagemakerTrainingJobExperimentConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobExperimentConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#experiment_name SagemakerTrainingJob#experiment_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "experimentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExperimentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#run_name SagemakerTrainingJob#run_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RunName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#trial_component_display_name SagemakerTrainingJob#trial_component_display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trialComponentDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrialComponentDisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#trial_name SagemakerTrainingJob#trial_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrialName
        {
            get;
            set;
        }
    }
}
