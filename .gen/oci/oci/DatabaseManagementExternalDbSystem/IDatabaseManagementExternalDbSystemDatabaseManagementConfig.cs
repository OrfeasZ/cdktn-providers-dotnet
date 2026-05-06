using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystem
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalDbSystemDatabaseManagementConfig), fullyQualifiedName: "oci.databaseManagementExternalDbSystem.DatabaseManagementExternalDbSystemDatabaseManagementConfig")]
    public interface IDatabaseManagementExternalDbSystemDatabaseManagementConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system#license_model DatabaseManagementExternalDbSystem#license_model}.</summary>
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        string LicenseModel
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalDbSystemDatabaseManagementConfig), fullyQualifiedName: "oci.databaseManagementExternalDbSystem.DatabaseManagementExternalDbSystemDatabaseManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalDbSystem.IDatabaseManagementExternalDbSystemDatabaseManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system#license_model DatabaseManagementExternalDbSystem#license_model}.</summary>
            [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
            public string LicenseModel
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
