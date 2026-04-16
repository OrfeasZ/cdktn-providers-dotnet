using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    [JsiiInterface(nativeType: typeof(IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser")]
    public interface IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#gid FsxS3AccessPointAttachment#gid}.</summary>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        double Gid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#uid FsxS3AccessPointAttachment#uid}.</summary>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        double Uid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#secondary_gids FsxS3AccessPointAttachment#secondary_gids}.</summary>
        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SecondaryGids
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser")]
        internal sealed class _Proxy : DeputyBase, aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOpenzfsConfigurationFileSystemIdentityPosixUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#gid FsxS3AccessPointAttachment#gid}.</summary>
            [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
            public double Gid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#uid FsxS3AccessPointAttachment#uid}.</summary>
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
            public double Uid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#secondary_gids FsxS3AccessPointAttachment#secondary_gids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? SecondaryGids
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
