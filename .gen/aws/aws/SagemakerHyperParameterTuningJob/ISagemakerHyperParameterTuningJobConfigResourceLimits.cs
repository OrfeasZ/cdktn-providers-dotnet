using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigResourceLimits), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigResourceLimits")]
    public interface ISagemakerHyperParameterTuningJobConfigResourceLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_parallel_training_jobs SagemakerHyperParameterTuningJob#max_parallel_training_jobs}.</summary>
        [JsiiProperty(name: "maxParallelTrainingJobs", typeJson: "{\"primitive\":\"number\"}")]
        double MaxParallelTrainingJobs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_number_of_training_jobs SagemakerHyperParameterTuningJob#max_number_of_training_jobs}.</summary>
        [JsiiProperty(name: "maxNumberOfTrainingJobs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxNumberOfTrainingJobs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_runtime_in_seconds SagemakerHyperParameterTuningJob#max_runtime_in_seconds}.</summary>
        [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRuntimeInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigResourceLimits), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigResourceLimits")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigResourceLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_parallel_training_jobs SagemakerHyperParameterTuningJob#max_parallel_training_jobs}.</summary>
            [JsiiProperty(name: "maxParallelTrainingJobs", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxParallelTrainingJobs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_number_of_training_jobs SagemakerHyperParameterTuningJob#max_number_of_training_jobs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxNumberOfTrainingJobs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxNumberOfTrainingJobs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_runtime_in_seconds SagemakerHyperParameterTuningJob#max_runtime_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRuntimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
