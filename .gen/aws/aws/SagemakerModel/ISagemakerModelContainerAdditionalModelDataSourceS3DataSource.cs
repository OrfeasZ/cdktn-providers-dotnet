using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainerAdditionalModelDataSourceS3DataSource), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSource")]
    public interface ISagemakerModelContainerAdditionalModelDataSourceS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#compression_type SagemakerModel#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}")]
        string CompressionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#s3_data_type SagemakerModel#s3_data_type}.</summary>
        [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
        string S3DataType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#s3_uri SagemakerModel#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string S3Uri
        {
            get;
        }

        /// <summary>model_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#model_access_config SagemakerModel#model_access_config}
        /// </remarks>
        [JsiiProperty(name: "modelAccessConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerModel.ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainerAdditionalModelDataSourceS3DataSource), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelContainerAdditionalModelDataSourceS3DataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#compression_type SagemakerModel#compression_type}.</summary>
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}")]
            public string CompressionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#s3_data_type SagemakerModel#s3_data_type}.</summary>
            [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
            public string S3DataType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#s3_uri SagemakerModel#s3_uri}.</summary>
            [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>model_access_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#model_access_config SagemakerModel#model_access_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modelAccessConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig\"}", isOptional: true)]
            public aws.SagemakerModel.ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig
            {
                get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig?>();
            }
        }
    }
}
