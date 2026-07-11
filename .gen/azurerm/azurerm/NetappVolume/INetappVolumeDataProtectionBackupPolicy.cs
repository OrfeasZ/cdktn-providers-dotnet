using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    [JsiiInterface(nativeType: typeof(INetappVolumeDataProtectionBackupPolicy), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeDataProtectionBackupPolicy")]
    public interface INetappVolumeDataProtectionBackupPolicy
    {
        /// <summary>The ID of the backup policy to associate with this volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume#backup_policy_id NetappVolume#backup_policy_id}
        /// </remarks>
        [JsiiProperty(name: "backupPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string BackupPolicyId
        {
            get;
        }

        /// <summary>The ID of the backup vault to associate with this volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume#backup_vault_id NetappVolume#backup_vault_id}
        /// </remarks>
        [JsiiProperty(name: "backupVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string BackupVaultId
        {
            get;
        }

        /// <summary>If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume#policy_enabled NetappVolume#policy_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "policyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PolicyEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeDataProtectionBackupPolicy), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeDataProtectionBackupPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolume.INetappVolumeDataProtectionBackupPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the backup policy to associate with this volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume#backup_policy_id NetappVolume#backup_policy_id}
            /// </remarks>
            [JsiiProperty(name: "backupPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the backup vault to associate with this volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume#backup_vault_id NetappVolume#backup_vault_id}
            /// </remarks>
            [JsiiProperty(name: "backupVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupVaultId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume#policy_enabled NetappVolume#policy_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PolicyEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
