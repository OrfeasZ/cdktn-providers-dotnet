using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecification")]
    public class SagemakerTrainingJobAlgorithmSpecification : aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecification
    {
        /// <summary>Name or ARN of a SageMaker algorithm resource. Exactly one of `algorithm_name` or `training_image` must be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#algorithm_name SagemakerTrainingJob#algorithm_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "algorithmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AlgorithmName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#container_arguments SagemakerTrainingJob#container_arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ContainerArguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#container_entrypoint SagemakerTrainingJob#container_entrypoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerEntrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ContainerEntrypoint
        {
            get;
            set;
        }

        private object? _enableSagemakerMetricsTimeSeries;

        /// <summary>Whether SageMaker AI should publish time-series metrics.</summary>
        /// <remarks>
        /// SageMaker enables this automatically for built-in algorithms, supported prebuilt images, and jobs with explicit <c>metric_definitions</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#enable_sagemaker_metrics_time_series SagemakerTrainingJob#enable_sagemaker_metrics_time_series}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableSagemakerMetricsTimeSeries", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableSagemakerMetricsTimeSeries
        {
            get => _enableSagemakerMetricsTimeSeries;
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
                _enableSagemakerMetricsTimeSeries = value;
            }
        }

        private object? _metricDefinitions;

        /// <summary>metric_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#metric_definitions SagemakerTrainingJob#metric_definitions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationMetricDefinitions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationMetricDefinitions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metricDefinitions = value;
            }
        }

        /// <summary>Registry path of the training image.</summary>
        /// <remarks>
        /// Exactly one of <c>algorithm_name</c> or <c>training_image</c> must be set. Use <c>metric_definitions</c> only when you need to extract custom metrics from your own training container logs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#training_image SagemakerTrainingJob#training_image}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingImage
        {
            get;
            set;
        }

        private object? _trainingImageConfig;

        /// <summary>training_image_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#training_image_config SagemakerTrainingJob#training_image_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trainingImageConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrainingImageConfig
        {
            get => _trainingImageConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trainingImageConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#training_input_mode SagemakerTrainingJob#training_input_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingInputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingInputMode
        {
            get;
            set;
        }
    }
}
