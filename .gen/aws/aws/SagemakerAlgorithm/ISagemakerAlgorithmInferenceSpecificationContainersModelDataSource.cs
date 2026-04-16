using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmInferenceSpecificationContainersModelDataSource), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSource")]
    public interface ISagemakerAlgorithmInferenceSpecificationContainersModelDataSource
    {
        /// <summary>s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#s3_data_source SagemakerAlgorithm#s3_data_source}
        /// </remarks>
        [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3DataSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmInferenceSpecificationContainersModelDataSource), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#s3_data_source SagemakerAlgorithm#s3_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3DataSource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
