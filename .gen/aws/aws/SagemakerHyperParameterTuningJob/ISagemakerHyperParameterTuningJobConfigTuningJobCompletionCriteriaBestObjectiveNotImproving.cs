using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving")]
    public interface ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_number_of_training_jobs_not_improving SagemakerHyperParameterTuningJob#max_number_of_training_jobs_not_improving}.</summary>
        [JsiiProperty(name: "maxNumberOfTrainingJobsNotImproving", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxNumberOfTrainingJobsNotImproving
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_number_of_training_jobs_not_improving SagemakerHyperParameterTuningJob#max_number_of_training_jobs_not_improving}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxNumberOfTrainingJobsNotImproving", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxNumberOfTrainingJobsNotImproving
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
