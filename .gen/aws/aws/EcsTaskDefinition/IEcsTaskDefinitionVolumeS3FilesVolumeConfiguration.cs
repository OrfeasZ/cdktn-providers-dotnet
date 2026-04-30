using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolumeS3FilesVolumeConfiguration), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeS3FilesVolumeConfiguration")]
    public interface IEcsTaskDefinitionVolumeS3FilesVolumeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_task_definition#file_system_arn EcsTaskDefinition#file_system_arn}.</summary>
        [JsiiProperty(name: "fileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_task_definition#access_point_arn EcsTaskDefinition#access_point_arn}.</summary>
        [JsiiProperty(name: "accessPointArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessPointArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_task_definition#root_directory EcsTaskDefinition#root_directory}.</summary>
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_task_definition#transit_encryption_port EcsTaskDefinition#transit_encryption_port}.</summary>
        [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TransitEncryptionPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolumeS3FilesVolumeConfiguration), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeS3FilesVolumeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeS3FilesVolumeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_task_definition#file_system_arn EcsTaskDefinition#file_system_arn}.</summary>
            [JsiiProperty(name: "fileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_task_definition#access_point_arn EcsTaskDefinition#access_point_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessPointArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessPointArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_task_definition#root_directory EcsTaskDefinition#root_directory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootDirectory
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_task_definition#transit_encryption_port EcsTaskDefinition#transit_encryption_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TransitEncryptionPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
