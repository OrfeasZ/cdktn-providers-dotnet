using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSourceS3DataSource")]
    public class SagemakerLabelingJobInputConfigDataSourceS3DataSource : aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSourceS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#manifest_s3_uri SagemakerLabelingJob#manifest_s3_uri}.</summary>
        [JsiiProperty(name: "manifestS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string ManifestS3Uri
        {
            get;
            set;
        }
    }
}
