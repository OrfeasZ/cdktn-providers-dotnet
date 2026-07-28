using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolume.NetappVolumeDataProtectionBackupPolicy")]
    public class NetappVolumeDataProtectionBackupPolicy : azurerm.NetappVolume.INetappVolumeDataProtectionBackupPolicy
    {
        /// <summary>The ID of the backup policy to associate with this volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume#backup_policy_id NetappVolume#backup_policy_id}
        /// </remarks>
        [JsiiProperty(name: "backupPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public string BackupPolicyId
        {
            get;
            set;
        }

        /// <summary>The ID of the backup vault to associate with this volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume#backup_vault_id NetappVolume#backup_vault_id}
        /// </remarks>
        [JsiiProperty(name: "backupVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string BackupVaultId
        {
            get;
            set;
        }

        private object? _policyEnabled;

        /// <summary>If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume#policy_enabled NetappVolume#policy_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PolicyEnabled
        {
            get => _policyEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _policyEnabled = value;
            }
        }
    }
}
