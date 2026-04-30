using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSource")]
    public class SagemakerLabelingJobInputConfigDataSource : aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSource
    {
        private object? _s3DataSource;

        /// <summary>s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#s3_data_source SagemakerLabelingJob#s3_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSourceS3DataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSourceS3DataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3DataSource = value;
            }
        }

        private object? _snsDataSource;

        /// <summary>sns_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#sns_data_source SagemakerLabelingJob#sns_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snsDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSourceSnsDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SnsDataSource
        {
            get => _snsDataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSourceSnsDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSourceSnsDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _snsDataSource = value;
            }
        }
    }
}
