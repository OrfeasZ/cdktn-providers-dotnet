using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser")]
    public class FsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser : aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentOntapConfigurationFileSystemIdentityWindowsUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/fsx_s3_access_point_attachment#name FsxS3AccessPointAttachment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
