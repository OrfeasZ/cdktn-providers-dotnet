using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesNetapp), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesNetapp")]
    public interface IAzurermProviderFeaturesNetapp
    {
        /// <summary>When enabled, backups will be deleted when the `azurerm_netapp_backup_vault` resource is destroyed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs#delete_backups_on_backup_vault_destroy AzurermProvider#delete_backups_on_backup_vault_destroy}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deleteBackupsOnBackupVaultDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteBackupsOnBackupVaultDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled, the volume will not be destroyed, safeguarding from severe data loss.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs#prevent_volume_destruction AzurermProvider#prevent_volume_destruction}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preventVolumeDestruction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreventVolumeDestruction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesNetapp), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesNetapp")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesNetapp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>When enabled, backups will be deleted when the `azurerm_netapp_backup_vault` resource is destroyed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs#delete_backups_on_backup_vault_destroy AzurermProvider#delete_backups_on_backup_vault_destroy}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteBackupsOnBackupVaultDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteBackupsOnBackupVaultDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled, the volume will not be destroyed, safeguarding from severe data loss.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs#prevent_volume_destruction AzurermProvider#prevent_volume_destruction}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preventVolumeDestruction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreventVolumeDestruction
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
