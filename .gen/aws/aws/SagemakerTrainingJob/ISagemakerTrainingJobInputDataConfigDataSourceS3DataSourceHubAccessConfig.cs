using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig")]
    public interface ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#hub_content_arn SagemakerTrainingJob#hub_content_arn}.</summary>
        [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        string HubContentArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#hub_content_arn SagemakerTrainingJob#hub_content_arn}.</summary>
            [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
            public string HubContentArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
