using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSource), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSource")]
    public interface ISagemakerTrainingJobInputDataConfigDataSource
    {
        /// <summary>file_system_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#file_system_data_source SagemakerTrainingJob#file_system_data_source}
        /// </remarks>
        [JsiiProperty(name: "fileSystemDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FileSystemDataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#s3_data_source SagemakerTrainingJob#s3_data_source}
        /// </remarks>
        [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3DataSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSource), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file_system_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#file_system_data_source SagemakerTrainingJob#file_system_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FileSystemDataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#s3_data_source SagemakerTrainingJob#s3_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3DataSource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
