using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateConnection.GoldenGateConnectionWarehouseStorage")]
    public class GoldenGateConnectionWarehouseStorage : oci.GoldenGateConnection.IGoldenGateConnectionWarehouseStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#storage_type GoldenGateConnection#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#access_key_id GoldenGateConnection#access_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_key GoldenGateConnection#account_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_key_secret_id GoldenGateConnection#account_key_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountKeySecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_name GoldenGateConnection#account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#endpoint_url GoldenGateConnection#endpoint_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#namespace GoldenGateConnection#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#region GoldenGateConnection#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#secret_access_key GoldenGateConnection#secret_access_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretAccessKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#secret_access_key_secret_id GoldenGateConnection#secret_access_key_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretAccessKeySecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#trust_store GoldenGateConnection#trust_store}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustStore
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#trust_store_secret_id GoldenGateConnection#trust_store_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustStoreSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustStoreSecretId
        {
            get;
            set;
        }
    }
}
