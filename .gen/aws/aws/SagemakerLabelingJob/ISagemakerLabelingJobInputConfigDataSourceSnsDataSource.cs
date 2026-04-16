using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobInputConfigDataSourceSnsDataSource), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSourceSnsDataSource")]
    public interface ISagemakerLabelingJobInputConfigDataSourceSnsDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#sns_topic_arn SagemakerLabelingJob#sns_topic_arn}.</summary>
        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        string SnsTopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobInputConfigDataSourceSnsDataSource), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSourceSnsDataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSourceSnsDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#sns_topic_arn SagemakerLabelingJob#sns_topic_arn}.</summary>
            [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsTopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
