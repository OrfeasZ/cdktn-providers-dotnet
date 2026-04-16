using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecification")]
    public class SagemakerAlgorithmTrainingSpecification : aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#supported_training_instance_types SagemakerAlgorithm#supported_training_instance_types}.</summary>
        [JsiiProperty(name: "supportedTrainingInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SupportedTrainingInstanceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#training_image SagemakerAlgorithm#training_image}.</summary>
        [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}")]
        public string TrainingImage
        {
            get;
            set;
        }

        private object? _additionalS3DataSource;

        /// <summary>additional_s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#additional_s3_data_source SagemakerAlgorithm#additional_s3_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalS3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalS3DataSource
        {
            get => _additionalS3DataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalS3DataSource = value;
            }
        }

        private object? _metricDefinitions;

        /// <summary>metric_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#metric_definitions SagemakerAlgorithm#metric_definitions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationMetricDefinitions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationMetricDefinitions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metricDefinitions = value;
            }
        }

        private object? _supportedHyperParameters;

        /// <summary>supported_hyper_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#supported_hyper_parameters SagemakerAlgorithm#supported_hyper_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "supportedHyperParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SupportedHyperParameters
        {
            get => _supportedHyperParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedHyperParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedHyperParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _supportedHyperParameters = value;
            }
        }

        private object? _supportedTuningJobObjectiveMetrics;

        /// <summary>supported_tuning_job_objective_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#supported_tuning_job_objective_metrics SagemakerAlgorithm#supported_tuning_job_objective_metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "supportedTuningJobObjectiveMetrics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SupportedTuningJobObjectiveMetrics
        {
            get => _supportedTuningJobObjectiveMetrics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _supportedTuningJobObjectiveMetrics = value;
            }
        }

        private object? _supportsDistributedTraining;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#supports_distributed_training SagemakerAlgorithm#supports_distributed_training}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "supportsDistributedTraining", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SupportsDistributedTraining
        {
            get => _supportsDistributedTraining;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _supportsDistributedTraining = value;
            }
        }

        private object? _trainingChannels;

        /// <summary>training_channels block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#training_channels SagemakerAlgorithm#training_channels}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trainingChannels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationTrainingChannels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrainingChannels
        {
            get => _trainingChannels;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationTrainingChannels[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationTrainingChannels).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trainingChannels = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#training_image_digest SagemakerAlgorithm#training_image_digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingImageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingImageDigest
        {
            get;
            set;
        }
    }
}
