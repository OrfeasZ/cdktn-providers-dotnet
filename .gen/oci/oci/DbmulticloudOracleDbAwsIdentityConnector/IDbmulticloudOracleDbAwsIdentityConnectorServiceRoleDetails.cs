using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAwsIdentityConnector
{
    [JsiiInterface(nativeType: typeof(IDbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails), fullyQualifiedName: "oci.dbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails")]
    public interface IDbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#role_arn DbmulticloudOracleDbAwsIdentityConnector#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#service_private_endpoint DbmulticloudOracleDbAwsIdentityConnector#service_private_endpoint}.</summary>
        [JsiiProperty(name: "servicePrivateEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePrivateEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#service_type DbmulticloudOracleDbAwsIdentityConnector#service_type}.</summary>
        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails), fullyQualifiedName: "oci.dbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DbmulticloudOracleDbAwsIdentityConnector.IDbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#role_arn DbmulticloudOracleDbAwsIdentityConnector#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#service_private_endpoint DbmulticloudOracleDbAwsIdentityConnector#service_private_endpoint}.</summary>
            [JsiiProperty(name: "servicePrivateEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePrivateEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dbmulticloud_oracle_db_aws_identity_connector#service_type DbmulticloudOracleDbAwsIdentityConnector#service_type}.</summary>
            [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
