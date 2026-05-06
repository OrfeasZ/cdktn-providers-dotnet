using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExternalPluggableDatabaseOperationsInsightsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseExternalPluggableDatabaseOperationsInsightsManagementTimeouts), fullyQualifiedName: "oci.databaseExternalPluggableDatabaseOperationsInsightsManagement.DatabaseExternalPluggableDatabaseOperationsInsightsManagementTimeouts")]
    public interface IDatabaseExternalPluggableDatabaseOperationsInsightsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_pluggable_database_operations_insights_management#create DatabaseExternalPluggableDatabaseOperationsInsightsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_pluggable_database_operations_insights_management#delete DatabaseExternalPluggableDatabaseOperationsInsightsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_pluggable_database_operations_insights_management#update DatabaseExternalPluggableDatabaseOperationsInsightsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExternalPluggableDatabaseOperationsInsightsManagementTimeouts), fullyQualifiedName: "oci.databaseExternalPluggableDatabaseOperationsInsightsManagement.DatabaseExternalPluggableDatabaseOperationsInsightsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExternalPluggableDatabaseOperationsInsightsManagement.IDatabaseExternalPluggableDatabaseOperationsInsightsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_pluggable_database_operations_insights_management#create DatabaseExternalPluggableDatabaseOperationsInsightsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_pluggable_database_operations_insights_management#delete DatabaseExternalPluggableDatabaseOperationsInsightsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_pluggable_database_operations_insights_management#update DatabaseExternalPluggableDatabaseOperationsInsightsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
