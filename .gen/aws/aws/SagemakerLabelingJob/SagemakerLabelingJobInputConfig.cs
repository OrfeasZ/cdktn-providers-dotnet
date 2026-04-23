using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfig")]
    public class SagemakerLabelingJobInputConfig : aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfig
    {
        private object? _dataAttributes;

        /// <summary>data_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#data_attributes SagemakerLabelingJob#data_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataAttributes
        {
            get => _dataAttributes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataAttributes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataAttributes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataAttributes = value;
            }
        }

        private object? _dataSource;

        /// <summary>data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#data_source SagemakerLabelingJob#data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataSource = value;
            }
        }
    }
}
