using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsConnectorDetails")]
    public class DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsConnectorDetails : oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsConnectorDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#connector_type DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#connector_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#database_connector_id DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#database_connector_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseConnectorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#management_agent_id DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#management_agent_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagementAgentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#private_end_point_id DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#private_end_point_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndPointId
        {
            get;
            set;
        }
    }
}
