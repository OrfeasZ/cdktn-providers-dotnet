using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAwsIdentityConnector
{
    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorTimeouts")]
    public class DbmulticloudOracleDbAwsIdentityConnectorTimeouts : oci.DbmulticloudOracleDbAwsIdentityConnector.IDbmulticloudOracleDbAwsIdentityConnectorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#create DbmulticloudOracleDbAwsIdentityConnector#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#delete DbmulticloudOracleDbAwsIdentityConnector#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#update DbmulticloudOracleDbAwsIdentityConnector#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
