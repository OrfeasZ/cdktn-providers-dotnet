using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails")]
    public class DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails : oci.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.IDatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails
    {
        /// <summary>connection_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#connection_credentials DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#connection_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.databaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials\"}", isOptional: true)]
        public oci.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.IDatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionCredentials? ConnectionCredentials
        {
            get;
            set;
        }

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#connection_string DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#connection_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.databaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString\"}", isOptional: true)]
        public oci.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.IDatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString? ConnectionString
        {
            get;
            set;
        }
    }
}
