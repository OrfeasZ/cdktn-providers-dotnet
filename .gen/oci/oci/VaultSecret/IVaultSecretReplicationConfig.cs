using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    [JsiiInterface(nativeType: typeof(IVaultSecretReplicationConfig), fullyQualifiedName: "oci.vaultSecret.VaultSecretReplicationConfig")]
    public interface IVaultSecretReplicationConfig
    {
        /// <summary>replication_targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#replication_targets VaultSecret#replication_targets}
        /// </remarks>
        [JsiiProperty(name: "replicationTargets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.vaultSecret.VaultSecretReplicationConfigReplicationTargets\"},\"kind\":\"array\"}}]}}")]
        object ReplicationTargets
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#is_write_forward_enabled VaultSecret#is_write_forward_enabled}.</summary>
        [JsiiProperty(name: "isWriteForwardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsWriteForwardEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVaultSecretReplicationConfig), fullyQualifiedName: "oci.vaultSecret.VaultSecretReplicationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.VaultSecret.IVaultSecretReplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>replication_targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#replication_targets VaultSecret#replication_targets}
            /// </remarks>
            [JsiiProperty(name: "replicationTargets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.vaultSecret.VaultSecretReplicationConfigReplicationTargets\"},\"kind\":\"array\"}}]}}")]
            public object ReplicationTargets
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#is_write_forward_enabled VaultSecret#is_write_forward_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isWriteForwardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsWriteForwardEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
