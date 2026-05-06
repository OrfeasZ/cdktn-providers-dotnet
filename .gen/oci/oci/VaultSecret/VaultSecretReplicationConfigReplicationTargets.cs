using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vaultSecret.VaultSecretReplicationConfigReplicationTargets")]
    public class VaultSecretReplicationConfigReplicationTargets : oci.VaultSecret.IVaultSecretReplicationConfigReplicationTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_key_id VaultSecret#target_key_id}.</summary>
        [JsiiProperty(name: "targetKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_region VaultSecret#target_region}.</summary>
        [JsiiProperty(name: "targetRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_vault_id VaultSecret#target_vault_id}.</summary>
        [JsiiProperty(name: "targetVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetVaultId
        {
            get;
            set;
        }
    }
}
