using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobInputConfigDataSourceS3DataSource), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSourceS3DataSource")]
    public interface ISagemakerLabelingJobInputConfigDataSourceS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#manifest_s3_uri SagemakerLabelingJob#manifest_s3_uri}.</summary>
        [JsiiProperty(name: "manifestS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string ManifestS3Uri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobInputConfigDataSourceS3DataSource), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataSourceS3DataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataSourceS3DataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#manifest_s3_uri SagemakerLabelingJob#manifest_s3_uri}.</summary>
            [JsiiProperty(name: "manifestS3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string ManifestS3Uri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
