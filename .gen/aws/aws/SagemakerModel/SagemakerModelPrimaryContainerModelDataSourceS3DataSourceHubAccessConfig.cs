using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfig")]
    public class SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfig : aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_model#hub_content_arn SagemakerModel#hub_content_arn}.</summary>
        [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        public string HubContentArn
        {
            get;
            set;
        }
    }
}
