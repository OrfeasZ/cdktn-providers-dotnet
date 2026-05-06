using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vaultSecret.VaultSecretReplicationConfig")]
    public class VaultSecretReplicationConfig : oci.VaultSecret.IVaultSecretReplicationConfig
    {
        private object _replicationTargets;

        /// <summary>replication_targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#replication_targets VaultSecret#replication_targets}
        /// </remarks>
        [JsiiProperty(name: "replicationTargets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.vaultSecret.VaultSecretReplicationConfigReplicationTargets\"},\"kind\":\"array\"}}]}}")]
        public object ReplicationTargets
        {
            get => _replicationTargets;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.VaultSecret.IVaultSecretReplicationConfigReplicationTargets[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.VaultSecret.IVaultSecretReplicationConfigReplicationTargets).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.VaultSecret.IVaultSecretReplicationConfigReplicationTargets).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _replicationTargets = value;
            }
        }

        private object? _isWriteForwardEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#is_write_forward_enabled VaultSecret#is_write_forward_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isWriteForwardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsWriteForwardEnabled
        {
            get => _isWriteForwardEnabled;
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
                _isWriteForwardEnabled = value;
            }
        }
    }
}
