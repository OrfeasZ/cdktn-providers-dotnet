using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAwsIdentityConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails")]
    public class DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails : oci.DbmulticloudOracleDbAwsIdentityConnector.IDbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#role_arn DbmulticloudOracleDbAwsIdentityConnector#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#service_private_endpoint DbmulticloudOracleDbAwsIdentityConnector#service_private_endpoint}.</summary>
        [JsiiProperty(name: "servicePrivateEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string ServicePrivateEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#service_type DbmulticloudOracleDbAwsIdentityConnector#service_type}.</summary>
        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceType
        {
            get;
            set;
        }
    }
}
