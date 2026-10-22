using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAwsKeyPool
{
    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbAwsKeyPool.DbmulticloudOracleDbAwsKeyPoolTimeouts")]
    public class DbmulticloudOracleDbAwsKeyPoolTimeouts : oci.DbmulticloudOracleDbAwsKeyPool.IDbmulticloudOracleDbAwsKeyPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#create DbmulticloudOracleDbAwsKeyPool#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#delete DbmulticloudOracleDbAwsKeyPool#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/dbmulticloud_oracle_db_aws_key_pool#update DbmulticloudOracleDbAwsKeyPool#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
