using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobMlflowConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobMlflowConfig")]
    public interface ISagemakerTrainingJobMlflowConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#mlflow_resource_arn SagemakerTrainingJob#mlflow_resource_arn}.</summary>
        [JsiiProperty(name: "mlflowResourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string MlflowResourceArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#mlflow_experiment_name SagemakerTrainingJob#mlflow_experiment_name}.</summary>
        [JsiiProperty(name: "mlflowExperimentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MlflowExperimentName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#mlflow_run_name SagemakerTrainingJob#mlflow_run_name}.</summary>
        [JsiiProperty(name: "mlflowRunName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MlflowRunName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobMlflowConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobMlflowConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobMlflowConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#mlflow_resource_arn SagemakerTrainingJob#mlflow_resource_arn}.</summary>
            [JsiiProperty(name: "mlflowResourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string MlflowResourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#mlflow_experiment_name SagemakerTrainingJob#mlflow_experiment_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mlflowExperimentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MlflowExperimentName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#mlflow_run_name SagemakerTrainingJob#mlflow_run_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mlflowRunName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MlflowRunName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
