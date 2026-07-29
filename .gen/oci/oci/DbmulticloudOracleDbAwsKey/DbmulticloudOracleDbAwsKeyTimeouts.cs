using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAwsKey
{
    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbAwsKey.DbmulticloudOracleDbAwsKeyTimeouts")]
    public class DbmulticloudOracleDbAwsKeyTimeouts : oci.DbmulticloudOracleDbAwsKey.IDbmulticloudOracleDbAwsKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dbmulticloud_oracle_db_aws_key#create DbmulticloudOracleDbAwsKey#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dbmulticloud_oracle_db_aws_key#delete DbmulticloudOracleDbAwsKey#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dbmulticloud_oracle_db_aws_key#update DbmulticloudOracleDbAwsKey#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
