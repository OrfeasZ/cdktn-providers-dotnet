using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiInterface(nativeType: typeof(IKeyVaultCertificateCertificatePolicyKeyProperties), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyProperties")]
    public interface IKeyVaultCertificateCertificatePolicyKeyProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#exportable KeyVaultCertificate#exportable}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "exportable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Exportable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#key_type KeyVaultCertificate#key_type}.</summary>
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        string KeyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#reuse_key KeyVaultCertificate#reuse_key}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "reuseKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ReuseKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#curve KeyVaultCertificate#curve}.</summary>
        [JsiiProperty(name: "curve", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Curve
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#key_size KeyVaultCertificate#key_size}.</summary>
        [JsiiProperty(name: "keySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeySize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultCertificateCertificatePolicyKeyProperties), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyProperties")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#exportable KeyVaultCertificate#exportable}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "exportable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Exportable
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#key_type KeyVaultCertificate#key_type}.</summary>
            [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#reuse_key KeyVaultCertificate#reuse_key}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "reuseKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ReuseKey
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#curve KeyVaultCertificate#curve}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "curve", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Curve
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_certificate#key_size KeyVaultCertificate#key_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeySize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
