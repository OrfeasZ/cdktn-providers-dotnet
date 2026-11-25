using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    [JsiiInterface(nativeType: typeof(IGoldenGateConnectionWarehouseStorage), fullyQualifiedName: "oci.goldenGateConnection.GoldenGateConnectionWarehouseStorage")]
    public interface IGoldenGateConnectionWarehouseStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#storage_type GoldenGateConnection#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#access_key_id GoldenGateConnection#access_key_id}.</summary>
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_key GoldenGateConnection#account_key}.</summary>
        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_key_secret_id GoldenGateConnection#account_key_secret_id}.</summary>
        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountKeySecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_name GoldenGateConnection#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#endpoint_url GoldenGateConnection#endpoint_url}.</summary>
        [JsiiProperty(name: "endpointUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#namespace GoldenGateConnection#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#region GoldenGateConnection#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#secret_access_key GoldenGateConnection#secret_access_key}.</summary>
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretAccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#secret_access_key_secret_id GoldenGateConnection#secret_access_key_secret_id}.</summary>
        [JsiiProperty(name: "secretAccessKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretAccessKeySecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#trust_store GoldenGateConnection#trust_store}.</summary>
        [JsiiProperty(name: "trustStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#trust_store_secret_id GoldenGateConnection#trust_store_secret_id}.</summary>
        [JsiiProperty(name: "trustStoreSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustStoreSecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGateConnectionWarehouseStorage), fullyQualifiedName: "oci.goldenGateConnection.GoldenGateConnectionWarehouseStorage")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGateConnection.IGoldenGateConnectionWarehouseStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#storage_type GoldenGateConnection#storage_type}.</summary>
            [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#access_key_id GoldenGateConnection#access_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_key GoldenGateConnection#account_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_key_secret_id GoldenGateConnection#account_key_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountKeySecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#account_name GoldenGateConnection#account_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#endpoint_url GoldenGateConnection#endpoint_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#namespace GoldenGateConnection#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#region GoldenGateConnection#region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#secret_access_key GoldenGateConnection#secret_access_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretAccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#secret_access_key_secret_id GoldenGateConnection#secret_access_key_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretAccessKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretAccessKeySecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#trust_store GoldenGateConnection#trust_store}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustStore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#trust_store_secret_id GoldenGateConnection#trust_store_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustStoreSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustStoreSecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
