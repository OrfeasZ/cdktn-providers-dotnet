using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbGcpIdentityConnector
{
    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbGcpIdentityConnector.DbmulticloudOracleDbGcpIdentityConnectorTimeouts")]
    public class DbmulticloudOracleDbGcpIdentityConnectorTimeouts : oci.DbmulticloudOracleDbGcpIdentityConnector.IDbmulticloudOracleDbGcpIdentityConnectorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#create DbmulticloudOracleDbGcpIdentityConnector#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#delete DbmulticloudOracleDbGcpIdentityConnector#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#update DbmulticloudOracleDbGcpIdentityConnector#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
