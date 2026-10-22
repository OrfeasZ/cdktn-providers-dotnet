using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateConnection.GoldenGateConnectionArtifactLocation")]
    public class GoldenGateConnectionArtifactLocation : oci.GoldenGateConnection.IGoldenGateConnectionArtifactLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#location_type GoldenGateConnection#location_type}.</summary>
        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        public string LocationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#account_key GoldenGateConnection#account_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#account_key_secret_id GoldenGateConnection#account_key_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountKeySecretId
        {
            get;
            set;
        }

        /// <summary>configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#configuration GoldenGateConnection#configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionArtifactLocationConfiguration\"}", isOptional: true)]
        public oci.GoldenGateConnection.IGoldenGateConnectionArtifactLocationConfiguration? Configuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#endpoint_suffix GoldenGateConnection#endpoint_suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointSuffix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#filesystem GoldenGateConnection#filesystem}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filesystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Filesystem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#path GoldenGateConnection#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        private object? _shouldOverwriteExisting;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#should_overwrite_existing GoldenGateConnection#should_overwrite_existing}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shouldOverwriteExisting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldOverwriteExisting
        {
            get => _shouldOverwriteExisting;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shouldOverwriteExisting = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/golden_gate_connection#storage_account GoldenGateConnection#storage_account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccount
        {
            get;
            set;
        }
    }
}
