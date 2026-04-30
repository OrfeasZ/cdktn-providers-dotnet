using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmTrainingSpecification), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecification")]
    public interface ISagemakerAlgorithmTrainingSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#supported_training_instance_types SagemakerAlgorithm#supported_training_instance_types}.</summary>
        [JsiiProperty(name: "supportedTrainingInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SupportedTrainingInstanceTypes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#training_image SagemakerAlgorithm#training_image}.</summary>
        [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}")]
        string TrainingImage
        {
            get;
        }

        /// <summary>additional_s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#additional_s3_data_source SagemakerAlgorithm#additional_s3_data_source}
        /// </remarks>
        [JsiiProperty(name: "additionalS3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalS3DataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#metric_definitions SagemakerAlgorithm#metric_definitions}
        /// </remarks>
        [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetricDefinitions
        {
            get
            {
                return null;
            }
        }

        /// <summary>supported_hyper_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#supported_hyper_parameters SagemakerAlgorithm#supported_hyper_parameters}
        /// </remarks>
        [JsiiProperty(name: "supportedHyperParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SupportedHyperParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>supported_tuning_job_objective_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#supported_tuning_job_objective_metrics SagemakerAlgorithm#supported_tuning_job_objective_metrics}
        /// </remarks>
        [JsiiProperty(name: "supportedTuningJobObjectiveMetrics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SupportedTuningJobObjectiveMetrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#supports_distributed_training SagemakerAlgorithm#supports_distributed_training}.</summary>
        [JsiiProperty(name: "supportsDistributedTraining", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SupportsDistributedTraining
        {
            get
            {
                return null;
            }
        }

        /// <summary>training_channels block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#training_channels SagemakerAlgorithm#training_channels}
        /// </remarks>
        [JsiiProperty(name: "trainingChannels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationTrainingChannels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrainingChannels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#training_image_digest SagemakerAlgorithm#training_image_digest}.</summary>
        [JsiiProperty(name: "trainingImageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrainingImageDigest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmTrainingSpecification), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#supported_training_instance_types SagemakerAlgorithm#supported_training_instance_types}.</summary>
            [JsiiProperty(name: "supportedTrainingInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SupportedTrainingInstanceTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#training_image SagemakerAlgorithm#training_image}.</summary>
            [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}")]
            public string TrainingImage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_s3_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#additional_s3_data_source SagemakerAlgorithm#additional_s3_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalS3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalS3DataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>metric_definitions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#metric_definitions SagemakerAlgorithm#metric_definitions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MetricDefinitions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>supported_hyper_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#supported_hyper_parameters SagemakerAlgorithm#supported_hyper_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supportedHyperParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SupportedHyperParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>supported_tuning_job_objective_metrics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#supported_tuning_job_objective_metrics SagemakerAlgorithm#supported_tuning_job_objective_metrics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supportedTuningJobObjectiveMetrics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SupportedTuningJobObjectiveMetrics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#supports_distributed_training SagemakerAlgorithm#supports_distributed_training}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportsDistributedTraining", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SupportsDistributedTraining
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>training_channels block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#training_channels SagemakerAlgorithm#training_channels}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trainingChannels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationTrainingChannels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrainingChannels
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#training_image_digest SagemakerAlgorithm#training_image_digest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trainingImageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrainingImageDigest
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
