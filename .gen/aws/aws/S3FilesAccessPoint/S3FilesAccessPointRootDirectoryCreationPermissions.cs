using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesAccessPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectoryCreationPermissions")]
    public class S3FilesAccessPointRootDirectoryCreationPermissions : aws.S3FilesAccessPoint.IS3FilesAccessPointRootDirectoryCreationPermissions
    {
        /// <summary>Owner group ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#owner_gid S3FilesAccessPoint#owner_gid}
        /// </remarks>
        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
        public double OwnerGid
        {
            get;
            set;
        }

        /// <summary>Owner user ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#owner_uid S3FilesAccessPoint#owner_uid}
        /// </remarks>
        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
        public double OwnerUid
        {
            get;
            set;
        }

        /// <summary>POSIX permissions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#permissions S3FilesAccessPoint#permissions}
        /// </remarks>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public string Permissions
        {
            get;
            set;
        }
    }
}
