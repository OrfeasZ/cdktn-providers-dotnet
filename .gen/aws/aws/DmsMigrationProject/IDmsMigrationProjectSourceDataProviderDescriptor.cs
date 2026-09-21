using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsMigrationProject
{
    [JsiiInterface(nativeType: typeof(IDmsMigrationProjectSourceDataProviderDescriptor), fullyQualifiedName: "aws.dmsMigrationProject.DmsMigrationProjectSourceDataProviderDescriptor")]
    public interface IDmsMigrationProjectSourceDataProviderDescriptor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#data_provider_arn DmsMigrationProject#data_provider_arn}.</summary>
        [JsiiProperty(name: "dataProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        string DataProviderArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#secrets_manager_access_role_arn DmsMigrationProject#secrets_manager_access_role_arn}.</summary>
        [JsiiProperty(name: "secretsManagerAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretsManagerAccessRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#secrets_manager_secret_id DmsMigrationProject#secrets_manager_secret_id}.</summary>
        [JsiiProperty(name: "secretsManagerSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretsManagerSecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsMigrationProjectSourceDataProviderDescriptor), fullyQualifiedName: "aws.dmsMigrationProject.DmsMigrationProjectSourceDataProviderDescriptor")]
        internal sealed class _Proxy : DeputyBase, aws.DmsMigrationProject.IDmsMigrationProjectSourceDataProviderDescriptor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#data_provider_arn DmsMigrationProject#data_provider_arn}.</summary>
            [JsiiProperty(name: "dataProviderArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DataProviderArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#secrets_manager_access_role_arn DmsMigrationProject#secrets_manager_access_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretsManagerAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretsManagerAccessRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/dms_migration_project#secrets_manager_secret_id DmsMigrationProject#secrets_manager_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretsManagerSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretsManagerSecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
