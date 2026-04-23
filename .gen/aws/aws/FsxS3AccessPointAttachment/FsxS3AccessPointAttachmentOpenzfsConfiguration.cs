using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfiguration")]
    public class FsxS3AccessPointAttachmentOpenzfsConfiguration : aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOpenzfsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_s3_access_point_attachment#volume_id FsxS3AccessPointAttachment#volume_id}.</summary>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeId
        {
            get;
            set;
        }

        private object? _fileSystemIdentity;

        /// <summary>file_system_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_s3_access_point_attachment#file_system_identity FsxS3AccessPointAttachment#file_system_identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FileSystemIdentity
        {
            get => _fileSystemIdentity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fileSystemIdentity = value;
            }
        }
    }
}
