using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesAccessPoint
{
    [JsiiInterface(nativeType: typeof(IS3FilesAccessPointRootDirectoryCreationPermissions), fullyQualifiedName: "aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectoryCreationPermissions")]
    public interface IS3FilesAccessPointRootDirectoryCreationPermissions
    {
        /// <summary>Owner group ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#owner_gid S3FilesAccessPoint#owner_gid}
        /// </remarks>
        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
        double OwnerGid
        {
            get;
        }

        /// <summary>Owner user ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#owner_uid S3FilesAccessPoint#owner_uid}
        /// </remarks>
        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
        double OwnerUid
        {
            get;
        }

        /// <summary>POSIX permissions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#permissions S3FilesAccessPoint#permissions}
        /// </remarks>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        string Permissions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3FilesAccessPointRootDirectoryCreationPermissions), fullyQualifiedName: "aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectoryCreationPermissions")]
        internal sealed class _Proxy : DeputyBase, aws.S3FilesAccessPoint.IS3FilesAccessPointRootDirectoryCreationPermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Owner group ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#owner_gid S3FilesAccessPoint#owner_gid}
            /// </remarks>
            [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
            public double OwnerGid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Owner user ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#owner_uid S3FilesAccessPoint#owner_uid}
            /// </remarks>
            [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
            public double OwnerUid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>POSIX permissions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3files_access_point#permissions S3FilesAccessPoint#permissions}
            /// </remarks>
            [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
            public string Permissions
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
