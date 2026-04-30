using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected")]
    public interface ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#complete_on_convergence SagemakerHyperParameterTuningJob#complete_on_convergence}.</summary>
        [JsiiProperty(name: "completeOnConvergence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompleteOnConvergence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#complete_on_convergence SagemakerHyperParameterTuningJob#complete_on_convergence}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "completeOnConvergence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompleteOnConvergence
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
