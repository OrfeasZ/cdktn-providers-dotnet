using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsMigrationProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dmsMigrationProject.DmsMigrationProjectSourceDataProviderDescriptor")]
    public class DmsMigrationProjectSourceDataProviderDescriptor : aws.DmsMigrationProject.IDmsMigrationProjectSourceDataProviderDescriptor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#data_provider_arn DmsMigrationProject#data_provider_arn}.</summary>
        [JsiiProperty(name: "dataProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DataProviderArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#secrets_manager_access_role_arn DmsMigrationProject#secrets_manager_access_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretsManagerAccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#secrets_manager_secret_id DmsMigrationProject#secrets_manager_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretsManagerSecretId
        {
            get;
            set;
        }
    }
}
