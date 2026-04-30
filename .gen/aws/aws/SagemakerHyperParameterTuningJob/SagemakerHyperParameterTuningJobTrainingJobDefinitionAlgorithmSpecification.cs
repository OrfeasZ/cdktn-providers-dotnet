using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_input_mode SagemakerHyperParameterTuningJob#training_input_mode}.</summary>
        [JsiiProperty(name: "trainingInputMode", typeJson: "{\"primitive\":\"string\"}")]
        public string TrainingInputMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#algorithm_name SagemakerHyperParameterTuningJob#algorithm_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "algorithmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AlgorithmName
        {
            get;
            set;
        }

        private object? _metricDefinitions;

        /// <summary>metric_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#metric_definitions SagemakerHyperParameterTuningJob#metric_definitions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetricDefinitions
        {
            get => _metricDefinitions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metricDefinitions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_image SagemakerHyperParameterTuningJob#training_image}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingImage
        {
            get;
            set;
        }
    }
}
