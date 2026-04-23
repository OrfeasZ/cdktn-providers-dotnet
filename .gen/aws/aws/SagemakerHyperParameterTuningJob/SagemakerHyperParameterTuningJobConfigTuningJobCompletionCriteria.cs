using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria")]
    public class SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria
    {
        private object? _bestObjectiveNotImproving;

        /// <summary>best_objective_not_improving block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#best_objective_not_improving SagemakerHyperParameterTuningJob#best_objective_not_improving}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bestObjectiveNotImproving", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BestObjectiveNotImproving
        {
            get => _bestObjectiveNotImproving;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bestObjectiveNotImproving = value;
            }
        }

        private object? _convergenceDetected;

        /// <summary>convergence_detected block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#convergence_detected SagemakerHyperParameterTuningJob#convergence_detected}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "convergenceDetected", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConvergenceDetected
        {
            get => _convergenceDetected;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _convergenceDetected = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#target_objective_metric_value SagemakerHyperParameterTuningJob#target_objective_metric_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetObjectiveMetricValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetObjectiveMetricValue
        {
            get;
            set;
        }
    }
}
