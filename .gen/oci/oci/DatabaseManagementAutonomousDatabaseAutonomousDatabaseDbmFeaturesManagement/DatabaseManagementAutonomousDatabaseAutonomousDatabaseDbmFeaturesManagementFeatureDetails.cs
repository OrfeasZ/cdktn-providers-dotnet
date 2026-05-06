using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetails")]
    public class DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetails : oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#feature DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        public string Feature
        {
            get;
            set;
        }

        /// <summary>connector_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#connector_details DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#connector_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
        public oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetails
        {
            get;
            set;
        }

        /// <summary>database_connection_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#database_connection_details DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#database_connection_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectionDetails", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails\"}", isOptional: true)]
        public oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails? DatabaseConnectionDetails
        {
            get;
            set;
        }
    }
}
