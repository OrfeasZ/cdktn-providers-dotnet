using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbGcpIdentityConnector
{
    [JsiiInterface(nativeType: typeof(IDbmulticloudOracleDbGcpIdentityConnectorTimeouts), fullyQualifiedName: "oci.dbmulticloudOracleDbGcpIdentityConnector.DbmulticloudOracleDbGcpIdentityConnectorTimeouts")]
    public interface IDbmulticloudOracleDbGcpIdentityConnectorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#create DbmulticloudOracleDbGcpIdentityConnector#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#delete DbmulticloudOracleDbGcpIdentityConnector#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#update DbmulticloudOracleDbGcpIdentityConnector#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbmulticloudOracleDbGcpIdentityConnectorTimeouts), fullyQualifiedName: "oci.dbmulticloudOracleDbGcpIdentityConnector.DbmulticloudOracleDbGcpIdentityConnectorTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DbmulticloudOracleDbGcpIdentityConnector.IDbmulticloudOracleDbGcpIdentityConnectorTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#create DbmulticloudOracleDbGcpIdentityConnector#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#delete DbmulticloudOracleDbGcpIdentityConnector#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#update DbmulticloudOracleDbGcpIdentityConnector#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
