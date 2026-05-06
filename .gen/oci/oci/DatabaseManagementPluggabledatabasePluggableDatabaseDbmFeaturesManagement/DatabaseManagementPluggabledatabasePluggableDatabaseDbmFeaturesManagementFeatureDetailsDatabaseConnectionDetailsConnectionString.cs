using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString")]
    public class DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString : oci.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.IDatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsConnectionString
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#connection_type DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#connection_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#port DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#protocol DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#service DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#service}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }
    }
}
