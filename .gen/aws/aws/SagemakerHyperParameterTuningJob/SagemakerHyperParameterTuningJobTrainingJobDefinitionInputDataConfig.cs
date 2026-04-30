using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfig")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfig : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#channel_name SagemakerHyperParameterTuningJob#channel_name}.</summary>
        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
        public string ChannelName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#compression_type SagemakerHyperParameterTuningJob#compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#content_type SagemakerHyperParameterTuningJob#content_type}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#data_source SagemakerHyperParameterTuningJob#data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataSource = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#input_mode SagemakerHyperParameterTuningJob#input_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#record_wrapper_type SagemakerHyperParameterTuningJob#record_wrapper_type}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#shuffle_config SagemakerHyperParameterTuningJob#shuffle_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shuffleConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shuffleConfig = value;
            }
        }
    }
}
