using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceHubAccessConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSourceHubAccessConfig")]
    public interface ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceHubAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_model#hub_content_arn SagemakerModel#hub_content_arn}.</summary>
        [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        string HubContentArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceHubAccessConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSourceHubAccessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceHubAccessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_model#hub_content_arn SagemakerModel#hub_content_arn}.</summary>
            [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
            public string HubContentArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
