using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails), fullyQualifiedName: "oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails")]
    public interface IDatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#password_secret_id DatabasePluggableDatabasePluggabledatabasemanagementsManagement#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string PasswordSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#user_name DatabasePluggableDatabasePluggabledatabasemanagementsManagement#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails), fullyQualifiedName: "oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementCredentialDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#password_secret_id DatabasePluggableDatabasePluggabledatabasemanagementsManagement#password_secret_id}.</summary>
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string PasswordSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#user_name DatabasePluggableDatabasePluggabledatabasemanagementsManagement#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
