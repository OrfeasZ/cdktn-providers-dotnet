using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesAccessPoint
{
    [JsiiInterface(nativeType: typeof(IS3FilesAccessPointRootDirectory), fullyQualifiedName: "aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectory")]
    public interface IS3FilesAccessPointRootDirectory
    {
        /// <summary>creation_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3files_access_point#creation_permissions S3FilesAccessPoint#creation_permissions}
        /// </remarks>
        [JsiiProperty(name: "creationPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectoryCreationPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreationPermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Root directory path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3files_access_point#path S3FilesAccessPoint#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3FilesAccessPointRootDirectory), fullyQualifiedName: "aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectory")]
        internal sealed class _Proxy : DeputyBase, aws.S3FilesAccessPoint.IS3FilesAccessPointRootDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>creation_permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3files_access_point#creation_permissions S3FilesAccessPoint#creation_permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creationPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectoryCreationPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CreationPermissions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Root directory path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3files_access_point#path S3FilesAccessPoint#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
