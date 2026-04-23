using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig")]
    public class SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#hub_content_arn SagemakerTrainingJob#hub_content_arn}.</summary>
        [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        public string HubContentArn
        {
            get;
            set;
        }
    }
}
