using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementDatabaseDbmFeaturesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails), fullyQualifiedName: "oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails")]
    public interface IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#feature DatabaseManagementDatabaseDbmFeaturesManagement#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        string Feature
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#can_enable_all_current_pdbs DatabaseManagementDatabaseDbmFeaturesManagement#can_enable_all_current_pdbs}.</summary>
        [JsiiProperty(name: "canEnableAllCurrentPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CanEnableAllCurrentPdbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>connector_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#connector_details DatabaseManagementDatabaseDbmFeaturesManagement#connector_details}
        /// </remarks>
        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>database_connection_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#database_connection_details DatabaseManagementDatabaseDbmFeaturesManagement#database_connection_details}
        /// </remarks>
        [JsiiProperty(name: "databaseConnectionDetails", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails? DatabaseConnectionDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#is_auto_enable_pluggable_database DatabaseManagementDatabaseDbmFeaturesManagement#is_auto_enable_pluggable_database}.</summary>
        [JsiiProperty(name: "isAutoEnablePluggableDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoEnablePluggableDatabase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#management_type DatabaseManagementDatabaseDbmFeaturesManagement#management_type}.</summary>
        [JsiiProperty(name: "managementType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagementType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails), fullyQualifiedName: "oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#feature DatabaseManagementDatabaseDbmFeaturesManagement#feature}.</summary>
            [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
            public string Feature
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#can_enable_all_current_pdbs DatabaseManagementDatabaseDbmFeaturesManagement#can_enable_all_current_pdbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "canEnableAllCurrentPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CanEnableAllCurrentPdbs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>connector_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#connector_details DatabaseManagementDatabaseDbmFeaturesManagement#connector_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
            public oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetails
            {
                get => GetInstanceProperty<oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails?>();
            }

            /// <summary>database_connection_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#database_connection_details DatabaseManagementDatabaseDbmFeaturesManagement#database_connection_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseConnectionDetails", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails\"}", isOptional: true)]
            public oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails? DatabaseConnectionDetails
            {
                get => GetInstanceProperty<oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#is_auto_enable_pluggable_database DatabaseManagementDatabaseDbmFeaturesManagement#is_auto_enable_pluggable_database}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoEnablePluggableDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoEnablePluggableDatabase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_database_dbm_features_management#management_type DatabaseManagementDatabaseDbmFeaturesManagement#management_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managementType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagementType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
