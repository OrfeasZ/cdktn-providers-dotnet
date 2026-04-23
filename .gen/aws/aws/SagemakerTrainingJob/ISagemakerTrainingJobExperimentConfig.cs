using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobExperimentConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobExperimentConfig")]
    public interface ISagemakerTrainingJobExperimentConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#experiment_name SagemakerTrainingJob#experiment_name}.</summary>
        [JsiiProperty(name: "experimentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExperimentName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#run_name SagemakerTrainingJob#run_name}.</summary>
        [JsiiProperty(name: "runName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RunName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#trial_component_display_name SagemakerTrainingJob#trial_component_display_name}.</summary>
        [JsiiProperty(name: "trialComponentDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrialComponentDisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#trial_name SagemakerTrainingJob#trial_name}.</summary>
        [JsiiProperty(name: "trialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrialName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobExperimentConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobExperimentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobExperimentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#experiment_name SagemakerTrainingJob#experiment_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "experimentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExperimentName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#run_name SagemakerTrainingJob#run_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#trial_component_display_name SagemakerTrainingJob#trial_component_display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trialComponentDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrialComponentDisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#trial_name SagemakerTrainingJob#trial_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrialName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
