using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbGcpKeyRing
{
    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbGcpKeyRing.DbmulticloudOracleDbGcpKeyRingTimeouts")]
    public class DbmulticloudOracleDbGcpKeyRingTimeouts : oci.DbmulticloudOracleDbGcpKeyRing.IDbmulticloudOracleDbGcpKeyRingTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_key_ring#create DbmulticloudOracleDbGcpKeyRing#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_key_ring#delete DbmulticloudOracleDbGcpKeyRing#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_key_ring#update DbmulticloudOracleDbGcpKeyRing#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
