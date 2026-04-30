using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity")]
    public class FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity : aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_s3_access_point_attachment#type FsxS3AccessPointAttachment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _posixUser;

        /// <summary>posix_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_s3_access_point_attachment#posix_user FsxS3AccessPointAttachment#posix_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "posixUser", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PosixUser
        {
            get => _posixUser;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _posixUser = value;
            }
        }
    }
}
