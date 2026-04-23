using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfig")]
    public class SagemakerTrainingJobInputDataConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#channel_name SagemakerTrainingJob#channel_name}.</summary>
        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
        public string ChannelName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#compression_type SagemakerTrainingJob#compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#content_type SagemakerTrainingJob#content_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentType
        {
            get;
            set;
        }

        private object? _dataSource;

        /// <summary>data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#data_source SagemakerTrainingJob#data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataSource
        {
            get => _dataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataSource = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#input_mode SagemakerTrainingJob#input_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#record_wrapper_type SagemakerTrainingJob#record_wrapper_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordWrapperType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordWrapperType
        {
            get;
            set;
        }

        private object? _shuffleConfig;

        /// <summary>shuffle_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#shuffle_config SagemakerTrainingJob#shuffle_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shuffleConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigShuffleConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ShuffleConfig
        {
            get => _shuffleConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigShuffleConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigShuffleConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shuffleConfig = value;
            }
        }
    }
}
