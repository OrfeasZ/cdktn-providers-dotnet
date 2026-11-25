using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateConnection.GoldenGateConnectionCatalogCatalogConfig")]
    public class GoldenGateConnectionCatalogCatalogConfig : oci.GoldenGateConnection.IGoldenGateConnectionCatalogCatalogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#catalog_config_type GoldenGateConnection#catalog_config_type}.</summary>
        [JsiiProperty(name: "catalogConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public string CatalogConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#database_id GoldenGateConnection#database_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#database_type GoldenGateConnection#database_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#deployment_id GoldenGateConnection#deployment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeploymentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#password GoldenGateConnection#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#password_secret_id GoldenGateConnection#password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#username GoldenGateConnection#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
