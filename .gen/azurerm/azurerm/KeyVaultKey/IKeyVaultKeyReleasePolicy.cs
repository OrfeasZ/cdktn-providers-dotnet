using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultKey
{
    [JsiiInterface(nativeType: typeof(IKeyVaultKeyReleasePolicy), fullyQualifiedName: "azurerm.keyVaultKey.KeyVaultKeyReleasePolicy")]
    public interface IKeyVaultKeyReleasePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/key_vault_key#json KeyVaultKey#json}.</summary>
        [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}")]
        string Json
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/key_vault_key#immutable KeyVaultKey#immutable}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "immutable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Immutable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultKeyReleasePolicy), fullyQualifiedName: "azurerm.keyVaultKey.KeyVaultKeyReleasePolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultKey.IKeyVaultKeyReleasePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/key_vault_key#json KeyVaultKey#json}.</summary>
            [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}")]
            public string Json
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/key_vault_key#immutable KeyVaultKey#immutable}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "immutable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Immutable
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
