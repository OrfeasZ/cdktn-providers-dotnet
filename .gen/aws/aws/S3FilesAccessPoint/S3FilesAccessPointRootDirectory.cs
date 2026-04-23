using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesAccessPoint
{
    [JsiiByValue(fqn: "aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectory")]
    public class S3FilesAccessPointRootDirectory : aws.S3FilesAccessPoint.IS3FilesAccessPointRootDirectory
    {
        private object? _creationPermissions;

        /// <summary>creation_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#creation_permissions S3FilesAccessPoint#creation_permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "creationPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3FilesAccessPoint.S3FilesAccessPointRootDirectoryCreationPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreationPermissions
        {
            get => _creationPermissions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.S3FilesAccessPoint.IS3FilesAccessPointRootDirectoryCreationPermissions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3FilesAccessPoint.IS3FilesAccessPointRootDirectoryCreationPermissions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _creationPermissions = value;
            }
        }

        /// <summary>Root directory path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_access_point#path S3FilesAccessPoint#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
