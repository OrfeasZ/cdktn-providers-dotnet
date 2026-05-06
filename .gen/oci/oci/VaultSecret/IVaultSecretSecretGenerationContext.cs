using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    [JsiiInterface(nativeType: typeof(IVaultSecretSecretGenerationContext), fullyQualifiedName: "oci.vaultSecret.VaultSecretSecretGenerationContext")]
    public interface IVaultSecretSecretGenerationContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#generation_template VaultSecret#generation_template}.</summary>
        [JsiiProperty(name: "generationTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string GenerationTemplate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#generation_type VaultSecret#generation_type}.</summary>
        [JsiiProperty(name: "generationType", typeJson: "{\"primitive\":\"string\"}")]
        string GenerationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#passphrase_length VaultSecret#passphrase_length}.</summary>
        [JsiiProperty(name: "passphraseLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PassphraseLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#secret_template VaultSecret#secret_template}.</summary>
        [JsiiProperty(name: "secretTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVaultSecretSecretGenerationContext), fullyQualifiedName: "oci.vaultSecret.VaultSecretSecretGenerationContext")]
        internal sealed class _Proxy : DeputyBase, oci.VaultSecret.IVaultSecretSecretGenerationContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#generation_template VaultSecret#generation_template}.</summary>
            [JsiiProperty(name: "generationTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string GenerationTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#generation_type VaultSecret#generation_type}.</summary>
            [JsiiProperty(name: "generationType", typeJson: "{\"primitive\":\"string\"}")]
            public string GenerationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#passphrase_length VaultSecret#passphrase_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passphraseLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PassphraseLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#secret_template VaultSecret#secret_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretTemplate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
