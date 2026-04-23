using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebSessionLogger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerLogConfigurationS3")]
    public class WorkspaceswebSessionLoggerLogConfigurationS3 : aws.WorkspaceswebSessionLogger.IWorkspaceswebSessionLoggerLogConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#bucket WorkspaceswebSessionLogger#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#folder_structure WorkspaceswebSessionLogger#folder_structure}.</summary>
        [JsiiProperty(name: "folderStructure", typeJson: "{\"primitive\":\"string\"}")]
        public string FolderStructure
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#log_file_format WorkspaceswebSessionLogger#log_file_format}.</summary>
        [JsiiProperty(name: "logFileFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string LogFileFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#bucket_owner WorkspaceswebSessionLogger#bucket_owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketOwner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#key_prefix WorkspaceswebSessionLogger#key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyPrefix
        {
            get;
            set;
        }
    }
}
