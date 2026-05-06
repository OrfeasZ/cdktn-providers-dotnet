using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemDatabaseManagementsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalDbSystemDatabaseManagementsManagementTimeouts), fullyQualifiedName: "oci.databaseManagementExternalDbSystemDatabaseManagementsManagement.DatabaseManagementExternalDbSystemDatabaseManagementsManagementTimeouts")]
    public interface IDatabaseManagementExternalDbSystemDatabaseManagementsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_database_managements_management#create DatabaseManagementExternalDbSystemDatabaseManagementsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_database_managements_management#delete DatabaseManagementExternalDbSystemDatabaseManagementsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_database_managements_management#update DatabaseManagementExternalDbSystemDatabaseManagementsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalDbSystemDatabaseManagementsManagementTimeouts), fullyQualifiedName: "oci.databaseManagementExternalDbSystemDatabaseManagementsManagement.DatabaseManagementExternalDbSystemDatabaseManagementsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalDbSystemDatabaseManagementsManagement.IDatabaseManagementExternalDbSystemDatabaseManagementsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_database_managements_management#create DatabaseManagementExternalDbSystemDatabaseManagementsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_database_managements_management#delete DatabaseManagementExternalDbSystemDatabaseManagementsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_database_managements_management#update DatabaseManagementExternalDbSystemDatabaseManagementsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
