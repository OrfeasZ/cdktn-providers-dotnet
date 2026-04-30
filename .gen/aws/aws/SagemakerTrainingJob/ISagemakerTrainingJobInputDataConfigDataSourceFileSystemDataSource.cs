using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource")]
    public interface ISagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#directory_path SagemakerTrainingJob#directory_path}.</summary>
        [JsiiProperty(name: "directoryPath", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_access_mode SagemakerTrainingJob#file_system_access_mode}.</summary>
        [JsiiProperty(name: "fileSystemAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemAccessMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_id SagemakerTrainingJob#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_type SagemakerTrainingJob#file_system_type}.</summary>
        [JsiiProperty(name: "fileSystemType", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#directory_path SagemakerTrainingJob#directory_path}.</summary>
            [JsiiProperty(name: "directoryPath", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_access_mode SagemakerTrainingJob#file_system_access_mode}.</summary>
            [JsiiProperty(name: "fileSystemAccessMode", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemAccessMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_id SagemakerTrainingJob#file_system_id}.</summary>
            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_type SagemakerTrainingJob#file_system_type}.</summary>
            [JsiiProperty(name: "fileSystemType", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
