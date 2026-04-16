using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeS3FilesVolumeConfiguration")]
    public class EcsTaskDefinitionVolumeS3FilesVolumeConfiguration : aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeS3FilesVolumeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_task_definition#file_system_arn EcsTaskDefinition#file_system_arn}.</summary>
        [JsiiProperty(name: "fileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_task_definition#access_point_arn EcsTaskDefinition#access_point_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessPointArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessPointArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_task_definition#root_directory EcsTaskDefinition#root_directory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDirectory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_task_definition#transit_encryption_port EcsTaskDefinition#transit_encryption_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TransitEncryptionPort
        {
            get;
            set;
        }
    }
}
