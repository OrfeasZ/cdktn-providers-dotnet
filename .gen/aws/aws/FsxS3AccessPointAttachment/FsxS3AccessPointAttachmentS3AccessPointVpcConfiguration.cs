using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    [JsiiByValue(fqn: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPointVpcConfiguration")]
    public class FsxS3AccessPointAttachmentS3AccessPointVpcConfiguration : aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentS3AccessPointVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_s3_access_point_attachment#vpc_id FsxS3AccessPointAttachment#vpc_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcId
        {
            get;
            set;
        }
    }
}
