using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vaultSecret.VaultSecretSecretGenerationContext")]
    public class VaultSecretSecretGenerationContext : oci.VaultSecret.IVaultSecretSecretGenerationContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#generation_template VaultSecret#generation_template}.</summary>
        [JsiiProperty(name: "generationTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public string GenerationTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#generation_type VaultSecret#generation_type}.</summary>
        [JsiiProperty(name: "generationType", typeJson: "{\"primitive\":\"string\"}")]
        public string GenerationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#passphrase_length VaultSecret#passphrase_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passphraseLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PassphraseLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#secret_template VaultSecret#secret_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretTemplate
        {
            get;
            set;
        }
    }
}
