using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSource), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSource")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSource
    {
        /// <summary>file_system_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#file_system_data_source SagemakerAlgorithm#file_system_data_source}
        /// </remarks>
        [JsiiProperty(name: "fileSystemDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceFileSystemDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#s3_data_source SagemakerAlgorithm#s3_data_source}
        /// </remarks>
        [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3DataSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSource), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file_system_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#file_system_data_source SagemakerAlgorithm#file_system_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceFileSystemDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FileSystemDataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#s3_data_source SagemakerAlgorithm#s3_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3DataSource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
