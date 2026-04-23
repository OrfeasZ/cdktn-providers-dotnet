using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobAlgorithmSpecification), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecification")]
    public interface ISagemakerTrainingJobAlgorithmSpecification
    {
        /// <summary>Name or ARN of a SageMaker algorithm resource. Exactly one of `algorithm_name` or `training_image` must be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#algorithm_name SagemakerTrainingJob#algorithm_name}
        /// </remarks>
        [JsiiProperty(name: "algorithmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlgorithmName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#container_arguments SagemakerTrainingJob#container_arguments}.</summary>
        [JsiiProperty(name: "containerArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ContainerArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#container_entrypoint SagemakerTrainingJob#container_entrypoint}.</summary>
        [JsiiProperty(name: "containerEntrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ContainerEntrypoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether SageMaker AI should publish time-series metrics.</summary>
        /// <remarks>
        /// SageMaker enables this automatically for built-in algorithms, supported prebuilt images, and jobs with explicit <c>metric_definitions</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#enable_sagemaker_metrics_time_series SagemakerTrainingJob#enable_sagemaker_metrics_time_series}
        /// </remarks>
        [JsiiProperty(name: "enableSagemakerMetricsTimeSeries", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableSagemakerMetricsTimeSeries
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#metric_definitions SagemakerTrainingJob#metric_definitions}
        /// </remarks>
        [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetricDefinitions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Registry path of the training image.</summary>
        /// <remarks>
        /// Exactly one of <c>algorithm_name</c> or <c>training_image</c> must be set. Use <c>metric_definitions</c> only when you need to extract custom metrics from your own training container logs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#training_image SagemakerTrainingJob#training_image}
        /// </remarks>
        [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrainingImage
        {
            get
            {
                return null;
            }
        }

        /// <summary>training_image_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#training_image_config SagemakerTrainingJob#training_image_config}
        /// </remarks>
        [JsiiProperty(name: "trainingImageConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrainingImageConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#training_input_mode SagemakerTrainingJob#training_input_mode}.</summary>
        [JsiiProperty(name: "trainingInputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrainingInputMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobAlgorithmSpecification), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name or ARN of a SageMaker algorithm resource. Exactly one of `algorithm_name` or `training_image` must be set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#algorithm_name SagemakerTrainingJob#algorithm_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "algorithmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlgorithmName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#container_arguments SagemakerTrainingJob#container_arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ContainerArguments
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#container_entrypoint SagemakerTrainingJob#container_entrypoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerEntrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ContainerEntrypoint
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether SageMaker AI should publish time-series metrics.</summary>
            /// <remarks>
            /// SageMaker enables this automatically for built-in algorithms, supported prebuilt images, and jobs with explicit <c>metric_definitions</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#enable_sagemaker_metrics_time_series SagemakerTrainingJob#enable_sagemaker_metrics_time_series}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableSagemakerMetricsTimeSeries", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableSagemakerMetricsTimeSeries
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>metric_definitions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#metric_definitions SagemakerTrainingJob#metric_definitions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MetricDefinitions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Registry path of the training image.</summary>
            /// <remarks>
            /// Exactly one of <c>algorithm_name</c> or <c>training_image</c> must be set. Use <c>metric_definitions</c> only when you need to extract custom metrics from your own training container logs.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#training_image SagemakerTrainingJob#training_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrainingImage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>training_image_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#training_image_config SagemakerTrainingJob#training_image_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trainingImageConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrainingImageConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#training_input_mode SagemakerTrainingJob#training_input_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trainingInputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrainingInputMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
