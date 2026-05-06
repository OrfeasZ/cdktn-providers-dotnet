using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials")]
    public class DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials : oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#credential_name DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#credential_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#credential_type DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#credential_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#password_secret_id DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#role DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Role
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#ssl_secret_id DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#ssl_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#user_name DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserName
        {
            get;
            set;
        }
    }
}
