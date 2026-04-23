using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    [JsiiInterface(nativeType: typeof(IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity")]
    public interface IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_s3_access_point_attachment#type FsxS3AccessPointAttachment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>posix_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_s3_access_point_attachment#posix_user FsxS3AccessPointAttachment#posix_user}
        /// </remarks>
        [JsiiProperty(name: "posixUser", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PosixUser
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity")]
        internal sealed class _Proxy : DeputyBase, aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_s3_access_point_attachment#type FsxS3AccessPointAttachment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>posix_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_s3_access_point_attachment#posix_user FsxS3AccessPointAttachment#posix_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "posixUser", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PosixUser
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
