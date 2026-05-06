using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateConnection.GoldenGateConnectionStorage")]
    public class GoldenGateConnectionStorage : oci.GoldenGateConnection.IGoldenGateConnectionStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#storage_type GoldenGateConnection#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#access_key_id GoldenGateConnection#access_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#account_key_secret_id GoldenGateConnection#account_key_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountKeySecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#account_name GoldenGateConnection#account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#bucket GoldenGateConnection#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#container GoldenGateConnection#container}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Container
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#endpoint GoldenGateConnection#endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#project_id GoldenGateConnection#project_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#region GoldenGateConnection#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#scheme_type GoldenGateConnection#scheme_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchemeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#secret_access_key_secret_id GoldenGateConnection#secret_access_key_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretAccessKeySecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#service_account_key_file_secret_id GoldenGateConnection#service_account_key_file_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountKeyFileSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccountKeyFileSecretId
        {
            get;
            set;
        }
    }
}
