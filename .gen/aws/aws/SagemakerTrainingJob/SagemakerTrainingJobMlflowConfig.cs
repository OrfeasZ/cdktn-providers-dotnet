using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobMlflowConfig")]
    public class SagemakerTrainingJobMlflowConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobMlflowConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#mlflow_resource_arn SagemakerTrainingJob#mlflow_resource_arn}.</summary>
        [JsiiProperty(name: "mlflowResourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string MlflowResourceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#mlflow_experiment_name SagemakerTrainingJob#mlflow_experiment_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mlflowExperimentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MlflowExperimentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#mlflow_run_name SagemakerTrainingJob#mlflow_run_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mlflowRunName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MlflowRunName
        {
            get;
            set;
        }
    }
}
