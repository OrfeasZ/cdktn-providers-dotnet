using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts), fullyQualifiedName: "oci.databaseManagementCloudDbSystemCloudDatabaseManagementsManagement.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts")]
    public interface IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#create DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#delete DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#update DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts), fullyQualifiedName: "oci.databaseManagementCloudDbSystemCloudDatabaseManagementsManagement.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement.IDatabaseManagementCloudDbSystemCloudDatabaseManagementsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#create DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#delete DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_database_managements_management#update DatabaseManagementCloudDbSystemCloudDatabaseManagementsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
