using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria")]
    public interface ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria
    {
        /// <summary>best_objective_not_improving block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#best_objective_not_improving SagemakerHyperParameterTuningJob#best_objective_not_improving}
        /// </remarks>
        [JsiiProperty(name: "bestObjectiveNotImproving", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BestObjectiveNotImproving
        {
            get
            {
                return null;
            }
        }

        /// <summary>convergence_detected block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#convergence_detected SagemakerHyperParameterTuningJob#convergence_detected}
        /// </remarks>
        [JsiiProperty(name: "convergenceDetected", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConvergenceDetected
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#target_objective_metric_value SagemakerHyperParameterTuningJob#target_objective_metric_value}.</summary>
        [JsiiProperty(name: "targetObjectiveMetricValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetObjectiveMetricValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>best_objective_not_improving block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#best_objective_not_improving SagemakerHyperParameterTuningJob#best_objective_not_improving}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bestObjectiveNotImproving", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaBestObjectiveNotImproving\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BestObjectiveNotImproving
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>convergence_detected block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#convergence_detected SagemakerHyperParameterTuningJob#convergence_detected}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "convergenceDetected", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteriaConvergenceDetected\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConvergenceDetected
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#target_objective_metric_value SagemakerHyperParameterTuningJob#target_objective_metric_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetObjectiveMetricValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetObjectiveMetricValue
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
