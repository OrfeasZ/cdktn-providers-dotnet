using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiByValue(fqn: "azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults")]
    public class AzurermProviderFeaturesRecoveryServicesVaults : azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults
    {
        private object? _recoverSoftDeletedBackupProtectedVm;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs#recover_soft_deleted_backup_protected_vm AzurermProvider#recover_soft_deleted_backup_protected_vm}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recoverSoftDeletedBackupProtectedVm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RecoverSoftDeletedBackupProtectedVm
        {
            get => _recoverSoftDeletedBackupProtectedVm;
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
                _recoverSoftDeletedBackupProtectedVm = value;
            }
        }
    }
}
