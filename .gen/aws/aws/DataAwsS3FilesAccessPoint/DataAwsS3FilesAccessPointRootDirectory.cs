using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsS3FilesAccessPoint
{
    [JsiiByValue(fqn: "aws.dataAwsS3FilesAccessPoint.DataAwsS3FilesAccessPointRootDirectory")]
    public class DataAwsS3FilesAccessPointRootDirectory : aws.DataAwsS3FilesAccessPoint.IDataAwsS3FilesAccessPointRootDirectory
    {
        private object? _creationPermissions;

        /// <summary>creation_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/s3files_access_point#creation_permissions DataAwsS3FilesAccessPoint#creation_permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "creationPermissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsS3FilesAccessPoint.DataAwsS3FilesAccessPointRootDirectoryCreationPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.DataAwsS3FilesAccessPoint.IDataAwsS3FilesAccessPointRootDirectoryCreationPermissions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsS3FilesAccessPoint.IDataAwsS3FilesAccessPointRootDirectoryCreationPermissions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _creationPermissions = value;
            }
        }
    }
}
