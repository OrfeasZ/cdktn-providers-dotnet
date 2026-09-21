using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsMigrationProject
{
    [JsiiInterface(nativeType: typeof(IDmsMigrationProjectSchemaConversionApplicationAttributes), fullyQualifiedName: "aws.dmsMigrationProject.DmsMigrationProjectSchemaConversionApplicationAttributes")]
    public interface IDmsMigrationProjectSchemaConversionApplicationAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#s3_bucket_path DmsMigrationProject#s3_bucket_path}.</summary>
        [JsiiProperty(name: "s3BucketPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BucketPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#s3_bucket_role_arn DmsMigrationProject#s3_bucket_role_arn}.</summary>
        [JsiiProperty(name: "s3BucketRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BucketRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsMigrationProjectSchemaConversionApplicationAttributes), fullyQualifiedName: "aws.dmsMigrationProject.DmsMigrationProjectSchemaConversionApplicationAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.DmsMigrationProject.IDmsMigrationProjectSchemaConversionApplicationAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#s3_bucket_path DmsMigrationProject#s3_bucket_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3BucketPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BucketPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#s3_bucket_role_arn DmsMigrationProject#s3_bucket_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3BucketRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BucketRoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
