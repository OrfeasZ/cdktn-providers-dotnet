using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementManagedDatabasesResetDatabaseParameter
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementManagedDatabasesResetDatabaseParameterTimeouts), fullyQualifiedName: "oci.databaseManagementManagedDatabasesResetDatabaseParameter.DatabaseManagementManagedDatabasesResetDatabaseParameterTimeouts")]
    public interface IDatabaseManagementManagedDatabasesResetDatabaseParameterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_reset_database_parameter#create DatabaseManagementManagedDatabasesResetDatabaseParameter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_reset_database_parameter#delete DatabaseManagementManagedDatabasesResetDatabaseParameter#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_reset_database_parameter#update DatabaseManagementManagedDatabasesResetDatabaseParameter#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementManagedDatabasesResetDatabaseParameterTimeouts), fullyQualifiedName: "oci.databaseManagementManagedDatabasesResetDatabaseParameter.DatabaseManagementManagedDatabasesResetDatabaseParameterTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementManagedDatabasesResetDatabaseParameter.IDatabaseManagementManagedDatabasesResetDatabaseParameterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_reset_database_parameter#create DatabaseManagementManagedDatabasesResetDatabaseParameter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_reset_database_parameter#delete DatabaseManagementManagedDatabasesResetDatabaseParameter#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_reset_database_parameter#update DatabaseManagementManagedDatabasesResetDatabaseParameter#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
