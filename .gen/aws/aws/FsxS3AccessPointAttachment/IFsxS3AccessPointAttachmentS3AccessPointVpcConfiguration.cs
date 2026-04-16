using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    [JsiiInterface(nativeType: typeof(IFsxS3AccessPointAttachmentS3AccessPointVpcConfiguration), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPointVpcConfiguration")]
    public interface IFsxS3AccessPointAttachmentS3AccessPointVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#vpc_id FsxS3AccessPointAttachment#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxS3AccessPointAttachmentS3AccessPointVpcConfiguration), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPointVpcConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentS3AccessPointVpcConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#vpc_id FsxS3AccessPointAttachment#vpc_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
