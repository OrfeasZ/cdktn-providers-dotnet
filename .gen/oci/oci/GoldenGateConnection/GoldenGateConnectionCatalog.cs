using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateConnection.GoldenGateConnectionCatalog")]
    public class GoldenGateConnectionCatalog : oci.GoldenGateConnection.IGoldenGateConnectionCatalog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#catalog_type GoldenGateConnection#catalog_type}.</summary>
        [JsiiProperty(name: "catalogType", typeJson: "{\"primitive\":\"string\"}")]
        public string CatalogType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#branch GoldenGateConnection#branch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Branch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#client_id GoldenGateConnection#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#client_secret_secret_id GoldenGateConnection#client_secret_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecretSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecretSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#glue_id GoldenGateConnection#glue_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "glueId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GlueId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#name GoldenGateConnection#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#principal_role GoldenGateConnection#principal_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principalRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrincipalRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#properties_secret_id GoldenGateConnection#properties_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "propertiesSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PropertiesSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#uri GoldenGateConnection#uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uri
        {
            get;
            set;
        }
    }
}
