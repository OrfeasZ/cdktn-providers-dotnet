using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSourceS3DataSource), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSourceS3DataSource")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSourceS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#s3_data_type SagemakerAlgorithm#s3_data_type}.</summary>
        [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
        string S3DataType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#s3_uri SagemakerAlgorithm#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string S3Uri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSourceS3DataSource), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSourceS3DataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSourceS3DataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#s3_data_type SagemakerAlgorithm#s3_data_type}.</summary>
            [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
            public string S3DataType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#s3_uri SagemakerAlgorithm#s3_uri}.</summary>
            [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Uri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
