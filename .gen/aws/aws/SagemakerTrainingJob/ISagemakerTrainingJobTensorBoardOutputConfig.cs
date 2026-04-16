using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobTensorBoardOutputConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobTensorBoardOutputConfig")]
    public interface ISagemakerTrainingJobTensorBoardOutputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#s3_output_path SagemakerTrainingJob#s3_output_path}.</summary>
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
        string S3OutputPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#local_path SagemakerTrainingJob#local_path}.</summary>
        [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobTensorBoardOutputConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobTensorBoardOutputConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobTensorBoardOutputConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#s3_output_path SagemakerTrainingJob#s3_output_path}.</summary>
            [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
            public string S3OutputPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#local_path SagemakerTrainingJob#local_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
