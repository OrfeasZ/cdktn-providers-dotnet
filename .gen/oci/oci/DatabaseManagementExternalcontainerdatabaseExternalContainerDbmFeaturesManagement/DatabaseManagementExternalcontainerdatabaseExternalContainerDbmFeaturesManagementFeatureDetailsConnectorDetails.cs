using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetailsConnectorDetails")]
    public class DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetailsConnectorDetails : oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetailsConnectorDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#connector_type DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#connector_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#database_connector_id DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#database_connector_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseConnectorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#management_agent_id DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#management_agent_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagementAgentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#private_end_point_id DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#private_end_point_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndPointId
        {
            get;
            set;
        }
    }
}
