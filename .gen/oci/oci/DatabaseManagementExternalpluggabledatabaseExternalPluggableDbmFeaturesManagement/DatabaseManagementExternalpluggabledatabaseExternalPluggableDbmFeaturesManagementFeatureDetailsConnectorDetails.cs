using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails")]
    public class DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails : oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#connector_type DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#connector_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#database_connector_id DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#database_connector_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseConnectorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#management_agent_id DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#management_agent_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagementAgentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#private_end_point_id DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#private_end_point_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndPointId
        {
            get;
            set;
        }
    }
}
