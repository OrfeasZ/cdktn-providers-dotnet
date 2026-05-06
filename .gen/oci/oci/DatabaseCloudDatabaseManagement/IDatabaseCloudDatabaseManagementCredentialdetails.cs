using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudDatabaseManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudDatabaseManagementCredentialdetails), fullyQualifiedName: "oci.databaseCloudDatabaseManagement.DatabaseCloudDatabaseManagementCredentialdetails")]
    public interface IDatabaseCloudDatabaseManagementCredentialdetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_database_management#password_secret_id DatabaseCloudDatabaseManagement#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string PasswordSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_database_management#user_name DatabaseCloudDatabaseManagement#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudDatabaseManagementCredentialdetails), fullyQualifiedName: "oci.databaseCloudDatabaseManagement.DatabaseCloudDatabaseManagementCredentialdetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudDatabaseManagement.IDatabaseCloudDatabaseManagementCredentialdetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_database_management#password_secret_id DatabaseCloudDatabaseManagement#password_secret_id}.</summary>
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string PasswordSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_database_management#user_name DatabaseCloudDatabaseManagement#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
