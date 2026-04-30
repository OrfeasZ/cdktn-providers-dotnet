using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource")]
    public class SagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource : aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSourceFileSystemDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#directory_path SagemakerTrainingJob#directory_path}.</summary>
        [JsiiProperty(name: "directoryPath", typeJson: "{\"primitive\":\"string\"}")]
        public string DirectoryPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_access_mode SagemakerTrainingJob#file_system_access_mode}.</summary>
        [JsiiProperty(name: "fileSystemAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemAccessMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_id SagemakerTrainingJob#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#file_system_type SagemakerTrainingJob#file_system_type}.</summary>
        [JsiiProperty(name: "fileSystemType", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemType
        {
            get;
            set;
        }
    }
}
