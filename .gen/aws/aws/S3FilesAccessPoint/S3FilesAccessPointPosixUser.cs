using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesAccessPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3FilesAccessPoint.S3FilesAccessPointPosixUser")]
    public class S3FilesAccessPointPosixUser : aws.S3FilesAccessPoint.IS3FilesAccessPointPosixUser
    {
        /// <summary>POSIX group ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#gid S3FilesAccessPoint#gid}
        /// </remarks>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        public double Gid
        {
            get;
            set;
        }

        /// <summary>POSIX user ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#uid S3FilesAccessPoint#uid}
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        public double Uid
        {
            get;
            set;
        }

        /// <summary>Secondary POSIX group IDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#secondary_gids S3FilesAccessPoint#secondary_gids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? SecondaryGids
        {
            get;
            set;
        }
    }
}
