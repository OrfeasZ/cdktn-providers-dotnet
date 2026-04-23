using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsS3FilesAccessPoint
{
    [JsiiInterface(nativeType: typeof(IDataAwsS3FilesAccessPointRootDirectory), fullyQualifiedName: "aws.dataAwsS3FilesAccessPoint.DataAwsS3FilesAccessPointRootDirectory")]
    public interface IDataAwsS3FilesAccessPointRootDirectory
    {
        /// <summary>creation_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/s3files_access_point#creation_permissions DataAwsS3FilesAccessPoint#creation_permissions}
        /// </remarks>
        [JsiiProperty(name: "creationPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsS3FilesAccessPoint.DataAwsS3FilesAccessPointRootDirectoryCreationPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreationPermissions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsS3FilesAccessPointRootDirectory), fullyQualifiedName: "aws.dataAwsS3FilesAccessPoint.DataAwsS3FilesAccessPointRootDirectory")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsS3FilesAccessPoint.IDataAwsS3FilesAccessPointRootDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>creation_permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/s3files_access_point#creation_permissions DataAwsS3FilesAccessPoint#creation_permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creationPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsS3FilesAccessPoint.DataAwsS3FilesAccessPointRootDirectoryCreationPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CreationPermissions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
