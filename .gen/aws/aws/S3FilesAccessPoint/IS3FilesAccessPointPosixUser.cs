using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesAccessPoint
{
    [JsiiInterface(nativeType: typeof(IS3FilesAccessPointPosixUser), fullyQualifiedName: "aws.s3FilesAccessPoint.S3FilesAccessPointPosixUser")]
    public interface IS3FilesAccessPointPosixUser
    {
        /// <summary>POSIX group ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#gid S3FilesAccessPoint#gid}
        /// </remarks>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        double Gid
        {
            get;
        }

        /// <summary>POSIX user ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#uid S3FilesAccessPoint#uid}
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        double Uid
        {
            get;
        }

        /// <summary>Secondary POSIX group IDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#secondary_gids S3FilesAccessPoint#secondary_gids}
        /// </remarks>
        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SecondaryGids
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3FilesAccessPointPosixUser), fullyQualifiedName: "aws.s3FilesAccessPoint.S3FilesAccessPointPosixUser")]
        internal sealed class _Proxy : DeputyBase, aws.S3FilesAccessPoint.IS3FilesAccessPointPosixUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>POSIX group ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#gid S3FilesAccessPoint#gid}
            /// </remarks>
            [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
            public double Gid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>POSIX user ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#uid S3FilesAccessPoint#uid}
            /// </remarks>
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
            public double Uid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Secondary POSIX group IDs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#secondary_gids S3FilesAccessPoint#secondary_gids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? SecondaryGids
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
