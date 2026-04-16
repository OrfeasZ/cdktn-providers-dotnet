using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSourceSnsDataSource")]
    public class SagemakerLabelingJobInputConfigDataSourceSnsDataSource : aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSourceSnsDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#sns_topic_arn SagemakerLabelingJob#sns_topic_arn}.</summary>
        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SnsTopicArn
        {
            get;
            set;
        }
    }
}
