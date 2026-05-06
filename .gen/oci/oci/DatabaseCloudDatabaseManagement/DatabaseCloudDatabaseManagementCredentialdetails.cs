using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudDatabaseManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseCloudDatabaseManagement.DatabaseCloudDatabaseManagementCredentialdetails")]
    public class DatabaseCloudDatabaseManagementCredentialdetails : oci.DatabaseCloudDatabaseManagement.IDatabaseCloudDatabaseManagementCredentialdetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_database_management#password_secret_id DatabaseCloudDatabaseManagement#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string PasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_database_management#user_name DatabaseCloudDatabaseManagement#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }
    }
}
