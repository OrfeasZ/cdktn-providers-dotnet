using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainerAdditionalModelDataSource), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSource")]
    public interface ISagemakerModelContainerAdditionalModelDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_model#channel_name SagemakerModel#channel_name}.</summary>
        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
        string ChannelName
        {
            get;
        }

        /// <summary>s3_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_model#s3_data_source SagemakerModel#s3_data_source}
        /// </remarks>
        [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}")]
        object S3DataSource
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainerAdditionalModelDataSource), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelContainerAdditionalModelDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_model#channel_name SagemakerModel#channel_name}.</summary>
            [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
            public string ChannelName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>s3_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_model#s3_data_source SagemakerModel#s3_data_source}
            /// </remarks>
            [JsiiProperty(name: "s3DataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSource\"},\"kind\":\"array\"}}]}}")]
            public object S3DataSource
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
