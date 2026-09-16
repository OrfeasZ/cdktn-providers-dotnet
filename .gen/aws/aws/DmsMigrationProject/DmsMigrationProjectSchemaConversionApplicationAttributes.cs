using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsMigrationProject
{
    [JsiiByValue(fqn: "aws.dmsMigrationProject.DmsMigrationProjectSchemaConversionApplicationAttributes")]
    public class DmsMigrationProjectSchemaConversionApplicationAttributes : aws.DmsMigrationProject.IDmsMigrationProjectSchemaConversionApplicationAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/dms_migration_project#s3_bucket_path DmsMigrationProject#s3_bucket_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BucketPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3BucketPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/dms_migration_project#s3_bucket_role_arn DmsMigrationProject#s3_bucket_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BucketRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3BucketRoleArn
        {
            get;
            set;
        }
    }
}
