using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAzureConnector
{
    [JsiiInterface(nativeType: typeof(IDbmulticloudOracleDbAzureConnectorTimeouts), fullyQualifiedName: "oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorTimeouts")]
    public interface IDbmulticloudOracleDbAzureConnectorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#create DbmulticloudOracleDbAzureConnector#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#delete DbmulticloudOracleDbAzureConnector#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#update DbmulticloudOracleDbAzureConnector#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbmulticloudOracleDbAzureConnectorTimeouts), fullyQualifiedName: "oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DbmulticloudOracleDbAzureConnector.IDbmulticloudOracleDbAzureConnectorTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#create DbmulticloudOracleDbAzureConnector#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#delete DbmulticloudOracleDbAzureConnector#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#update DbmulticloudOracleDbAzureConnector#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
