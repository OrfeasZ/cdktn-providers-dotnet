using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_input_mode SagemakerHyperParameterTuningJob#training_input_mode}.</summary>
        [JsiiProperty(name: "trainingInputMode", typeJson: "{\"primitive\":\"string\"}")]
        string TrainingInputMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#algorithm_name SagemakerHyperParameterTuningJob#algorithm_name}.</summary>
        [JsiiProperty(name: "algorithmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlgorithmName
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#metric_definitions SagemakerHyperParameterTuningJob#metric_definitions}
        /// </remarks>
        [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetricDefinitions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_image SagemakerHyperParameterTuningJob#training_image}.</summary>
        [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrainingImage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_input_mode SagemakerHyperParameterTuningJob#training_input_mode}.</summary>
            [JsiiProperty(name: "trainingInputMode", typeJson: "{\"primitive\":\"string\"}")]
            public string TrainingInputMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#algorithm_name SagemakerHyperParameterTuningJob#algorithm_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "algorithmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlgorithmName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metric_definitions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#metric_definitions SagemakerHyperParameterTuningJob#metric_definitions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MetricDefinitions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_image SagemakerHyperParameterTuningJob#training_image}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrainingImage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
