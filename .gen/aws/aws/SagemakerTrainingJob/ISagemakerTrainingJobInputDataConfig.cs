using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobInputDataConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfig")]
    public interface ISagemakerTrainingJobInputDataConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#channel_name SagemakerTrainingJob#channel_name}.</summary>
        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
        string ChannelName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#compression_type SagemakerTrainingJob#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#content_type SagemakerTrainingJob#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#data_source SagemakerTrainingJob#data_source}
        /// </remarks>
        [JsiiProperty(name: "dataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#input_mode SagemakerTrainingJob#input_mode}.</summary>
        [JsiiProperty(name: "inputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#record_wrapper_type SagemakerTrainingJob#record_wrapper_type}.</summary>
        [JsiiProperty(name: "recordWrapperType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordWrapperType
        {
            get
            {
                return null;
            }
        }

        /// <summary>shuffle_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#shuffle_config SagemakerTrainingJob#shuffle_config}
        /// </remarks>
        [JsiiProperty(name: "shuffleConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigShuffleConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShuffleConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobInputDataConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#channel_name SagemakerTrainingJob#channel_name}.</summary>
            [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
            public string ChannelName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#compression_type SagemakerTrainingJob#compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#content_type SagemakerTrainingJob#content_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#data_source SagemakerTrainingJob#data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#input_mode SagemakerTrainingJob#input_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#record_wrapper_type SagemakerTrainingJob#record_wrapper_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recordWrapperType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordWrapperType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>shuffle_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#shuffle_config SagemakerTrainingJob#shuffle_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shuffleConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigShuffleConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ShuffleConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
