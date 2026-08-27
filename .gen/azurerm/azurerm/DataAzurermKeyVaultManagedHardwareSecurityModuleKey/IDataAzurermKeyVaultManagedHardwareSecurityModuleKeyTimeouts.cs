using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleKey
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts), fullyQualifiedName: "azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleKey.DataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts")]
    public interface IDataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/key_vault_managed_hardware_security_module_key#read DataAzurermKeyVaultManagedHardwareSecurityModuleKey#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts), fullyQualifiedName: "azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleKey.DataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleKey.IDataAzurermKeyVaultManagedHardwareSecurityModuleKeyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/key_vault_managed_hardware_security_module_key#read DataAzurermKeyVaultManagedHardwareSecurityModuleKey#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
