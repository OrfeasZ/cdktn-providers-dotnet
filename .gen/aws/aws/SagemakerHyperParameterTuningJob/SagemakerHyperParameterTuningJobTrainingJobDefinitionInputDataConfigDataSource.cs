using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSource")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSource : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSource
    {
        private object? _fileSystemDataSource;

        /// <summary>file_system_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#file_system_data_source SagemakerHyperParameterTuningJob#file_system_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceFileSystemDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FileSystemDataSource
        {
            get => _fileSystemDataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceFileSystemDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceFileSystemDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fileSystemDataSource = value;
            }
        }

        private object? _s3DataSource;

        /// <summary>s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#s3_data_source SagemakerHyperParameterTuningJob#s3_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3DataSource
        {
            get => _s3DataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceS3DataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceS3DataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3DataSource = value;
            }
        }
    }
}
