using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected")]
    public class SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#complete_on_convergence SagemakerHyperParameterTuningJob#complete_on_convergence}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "completeOnConvergence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompleteOnConvergence
        {
            get;
            set;
        }
    }
}
