using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    [JsiiInterface(nativeType: typeof(IFsxS3AccessPointAttachmentOntapConfiguration), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfiguration")]
    public interface IFsxS3AccessPointAttachmentOntapConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/fsx_s3_access_point_attachment#volume_id FsxS3AccessPointAttachment#volume_id}.</summary>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeId
        {
            get;
        }

        /// <summary>file_system_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/fsx_s3_access_point_attachment#file_system_identity FsxS3AccessPointAttachment#file_system_identity}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentity" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "fileSystemIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FileSystemIdentity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxS3AccessPointAttachmentOntapConfiguration), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/fsx_s3_access_point_attachment#volume_id FsxS3AccessPointAttachment#volume_id}.</summary>
            [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>file_system_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/fsx_s3_access_point_attachment#file_system_identity FsxS3AccessPointAttachment#file_system_identity}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentity" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FileSystemIdentity
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
