using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetails")]
    public class VaultSecretRotationConfigTargetSystemDetails : oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_system_type VaultSecret#target_system_type}.</summary>
        [JsiiProperty(name: "targetSystemType", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetSystemType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#adb_id VaultSecret#adb_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adbId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdbId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#function_id VaultSecret#function_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FunctionId
        {
            get;
            set;
        }
    }
}
