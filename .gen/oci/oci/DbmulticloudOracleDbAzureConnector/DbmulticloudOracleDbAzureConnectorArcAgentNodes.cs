using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAzureConnector
{
    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorArcAgentNodes")]
    public class DbmulticloudOracleDbAzureConnectorArcAgentNodes : oci.DbmulticloudOracleDbAzureConnector.IDbmulticloudOracleDbAzureConnectorArcAgentNodes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#current_arc_agent_version DbmulticloudOracleDbAzureConnector#current_arc_agent_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currentArcAgentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrentArcAgentVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#host_id DbmulticloudOracleDbAzureConnector#host_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#host_name DbmulticloudOracleDbAzureConnector#host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#status DbmulticloudOracleDbAzureConnector#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#time_last_checked DbmulticloudOracleDbAzureConnector#time_last_checked}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeLastChecked", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeLastChecked
        {
            get;
            set;
        }
    }
}
