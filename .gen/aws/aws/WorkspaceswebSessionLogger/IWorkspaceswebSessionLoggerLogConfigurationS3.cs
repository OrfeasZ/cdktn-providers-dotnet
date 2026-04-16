using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebSessionLogger
{
    [JsiiInterface(nativeType: typeof(IWorkspaceswebSessionLoggerLogConfigurationS3), fullyQualifiedName: "aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerLogConfigurationS3")]
    public interface IWorkspaceswebSessionLoggerLogConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#bucket WorkspaceswebSessionLogger#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#folder_structure WorkspaceswebSessionLogger#folder_structure}.</summary>
        [JsiiProperty(name: "folderStructure", typeJson: "{\"primitive\":\"string\"}")]
        string FolderStructure
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#log_file_format WorkspaceswebSessionLogger#log_file_format}.</summary>
        [JsiiProperty(name: "logFileFormat", typeJson: "{\"primitive\":\"string\"}")]
        string LogFileFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#bucket_owner WorkspaceswebSessionLogger#bucket_owner}.</summary>
        [JsiiProperty(name: "bucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketOwner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#key_prefix WorkspaceswebSessionLogger#key_prefix}.</summary>
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspaceswebSessionLoggerLogConfigurationS3), fullyQualifiedName: "aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerLogConfigurationS3")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspaceswebSessionLogger.IWorkspaceswebSessionLoggerLogConfigurationS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#bucket WorkspaceswebSessionLogger#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#folder_structure WorkspaceswebSessionLogger#folder_structure}.</summary>
            [JsiiProperty(name: "folderStructure", typeJson: "{\"primitive\":\"string\"}")]
            public string FolderStructure
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#log_file_format WorkspaceswebSessionLogger#log_file_format}.</summary>
            [JsiiProperty(name: "logFileFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string LogFileFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#bucket_owner WorkspaceswebSessionLogger#bucket_owner}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketOwner
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_session_logger#key_prefix WorkspaceswebSessionLogger#key_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
