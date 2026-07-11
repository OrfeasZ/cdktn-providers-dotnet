using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleKey
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleKey.DataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts")]
    public class DataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts : azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleKey.IDataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/key_vault_managed_hardware_security_module_key#read DataAzurermKeyVaultManagedHardwareSecurityModuleKey#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
