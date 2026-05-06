using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails), fullyQualifiedName: "oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails")]
    public interface IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#connector_type DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectorType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#database_connector_id DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#database_connector_id}.</summary>
        [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseConnectorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#management_agent_id DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#management_agent_id}.</summary>
        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagementAgentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#private_end_point_id DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#private_end_point_id}.</summary>
        [JsiiProperty(name: "privateEndPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndPointId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails), fullyQualifiedName: "oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#connector_type DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#connector_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectorType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#database_connector_id DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#database_connector_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseConnectorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#management_agent_id DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#management_agent_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagementAgentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_autonomous_database_autonomous_database_dbm_features_management#private_end_point_id DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement#private_end_point_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndPointId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
