using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementDatabaseDbmFeaturesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials), fullyQualifiedName: "oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials")]
    public interface IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#credential_name DatabaseManagementDatabaseDbmFeaturesManagement#credential_name}.</summary>
        [JsiiProperty(name: "credentialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#credential_type DatabaseManagementDatabaseDbmFeaturesManagement#credential_type}.</summary>
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#named_credential_id DatabaseManagementDatabaseDbmFeaturesManagement#named_credential_id}.</summary>
        [JsiiProperty(name: "namedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamedCredentialId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#password_secret_id DatabaseManagementDatabaseDbmFeaturesManagement#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#role DatabaseManagementDatabaseDbmFeaturesManagement#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Role
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#ssl_secret_id DatabaseManagementDatabaseDbmFeaturesManagement#ssl_secret_id}.</summary>
        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#user_name DatabaseManagementDatabaseDbmFeaturesManagement#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials), fullyQualifiedName: "oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#credential_name DatabaseManagementDatabaseDbmFeaturesManagement#credential_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#credential_type DatabaseManagementDatabaseDbmFeaturesManagement#credential_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#named_credential_id DatabaseManagementDatabaseDbmFeaturesManagement#named_credential_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamedCredentialId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#password_secret_id DatabaseManagementDatabaseDbmFeaturesManagement#password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#role DatabaseManagementDatabaseDbmFeaturesManagement#role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Role
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#ssl_secret_id DatabaseManagementDatabaseDbmFeaturesManagement#ssl_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#user_name DatabaseManagementDatabaseDbmFeaturesManagement#user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
