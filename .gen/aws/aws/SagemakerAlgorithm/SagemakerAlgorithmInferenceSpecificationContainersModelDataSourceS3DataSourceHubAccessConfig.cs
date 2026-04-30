using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceHubAccessConfig")]
    public class SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceHubAccessConfig : aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceHubAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_algorithm#hub_content_arn SagemakerAlgorithm#hub_content_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HubContentArn
        {
            get;
            set;
        }
    }
}
