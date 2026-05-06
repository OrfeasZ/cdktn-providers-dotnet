using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    [JsiiInterface(nativeType: typeof(IVaultSecretReplicationConfigReplicationTargets), fullyQualifiedName: "oci.vaultSecret.VaultSecretReplicationConfigReplicationTargets")]
    public interface IVaultSecretReplicationConfigReplicationTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_key_id VaultSecret#target_key_id}.</summary>
        [JsiiProperty(name: "targetKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_region VaultSecret#target_region}.</summary>
        [JsiiProperty(name: "targetRegion", typeJson: "{\"primitive\":\"string\"}")]
        string TargetRegion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_vault_id VaultSecret#target_vault_id}.</summary>
        [JsiiProperty(name: "targetVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVaultSecretReplicationConfigReplicationTargets), fullyQualifiedName: "oci.vaultSecret.VaultSecretReplicationConfigReplicationTargets")]
        internal sealed class _Proxy : DeputyBase, oci.VaultSecret.IVaultSecretReplicationConfigReplicationTargets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_key_id VaultSecret#target_key_id}.</summary>
            [JsiiProperty(name: "targetKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_region VaultSecret#target_region}.</summary>
            [JsiiProperty(name: "targetRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_vault_id VaultSecret#target_vault_id}.</summary>
            [JsiiProperty(name: "targetVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
