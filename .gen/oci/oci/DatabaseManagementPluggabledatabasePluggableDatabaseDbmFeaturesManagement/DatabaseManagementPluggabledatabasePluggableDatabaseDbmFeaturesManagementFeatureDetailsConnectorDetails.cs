using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails")]
    public class DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails : oci.DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement.IDatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#connector_type DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#connector_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#database_connector_id DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#database_connector_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseConnectorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#management_agent_id DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#management_agent_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagementAgentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_pluggabledatabase_pluggable_database_dbm_features_management#private_end_point_id DatabaseManagementPluggabledatabasePluggableDatabaseDbmFeaturesManagement#private_end_point_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndPointId
        {
            get;
            set;
        }
    }
}
