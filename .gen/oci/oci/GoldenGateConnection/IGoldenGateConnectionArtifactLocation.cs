using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    [JsiiInterface(nativeType: typeof(IGoldenGateConnectionArtifactLocation), fullyQualifiedName: "oci.goldenGateConnection.GoldenGateConnectionArtifactLocation")]
    public interface IGoldenGateConnectionArtifactLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#location_type GoldenGateConnection#location_type}.</summary>
        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        string LocationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#account_key GoldenGateConnection#account_key}.</summary>
        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#account_key_secret_id GoldenGateConnection#account_key_secret_id}.</summary>
        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountKeySecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#configuration GoldenGateConnection#configuration}
        /// </remarks>
        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionArtifactLocationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GoldenGateConnection.IGoldenGateConnectionArtifactLocationConfiguration? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#endpoint_suffix GoldenGateConnection#endpoint_suffix}.</summary>
        [JsiiProperty(name: "endpointSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#filesystem GoldenGateConnection#filesystem}.</summary>
        [JsiiProperty(name: "filesystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#path GoldenGateConnection#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#should_overwrite_existing GoldenGateConnection#should_overwrite_existing}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "shouldOverwriteExisting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldOverwriteExisting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#storage_account GoldenGateConnection#storage_account}.</summary>
        [JsiiProperty(name: "storageAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGateConnectionArtifactLocation), fullyQualifiedName: "oci.goldenGateConnection.GoldenGateConnectionArtifactLocation")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGateConnection.IGoldenGateConnectionArtifactLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#location_type GoldenGateConnection#location_type}.</summary>
            [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
            public string LocationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#account_key GoldenGateConnection#account_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#account_key_secret_id GoldenGateConnection#account_key_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountKeySecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#configuration GoldenGateConnection#configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionArtifactLocationConfiguration\"}", isOptional: true)]
            public oci.GoldenGateConnection.IGoldenGateConnectionArtifactLocationConfiguration? Configuration
            {
                get => GetInstanceProperty<oci.GoldenGateConnection.IGoldenGateConnectionArtifactLocationConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#endpoint_suffix GoldenGateConnection#endpoint_suffix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointSuffix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#filesystem GoldenGateConnection#filesystem}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filesystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filesystem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#path GoldenGateConnection#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#should_overwrite_existing GoldenGateConnection#should_overwrite_existing}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shouldOverwriteExisting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldOverwriteExisting
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#storage_account GoldenGateConnection#storage_account}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccount
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
