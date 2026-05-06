using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails), fullyQualifiedName: "oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails")]
    public interface IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails
    {
        /// <summary>connection_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#connection_credentials DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#connection_credentials}
        /// </remarks>
        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials? ConnectionCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#connection_string DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#connection_string}
        /// </remarks>
        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString? ConnectionString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails), fullyQualifiedName: "oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connection_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#connection_credentials DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#connection_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials\"}", isOptional: true)]
            public oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials? ConnectionCredentials
            {
                get => GetInstanceProperty<oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials?>();
            }

            /// <summary>connection_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#connection_string DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#connection_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString\"}", isOptional: true)]
            public oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString? ConnectionString
            {
                get => GetInstanceProperty<oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString?>();
            }
        }
    }
}
