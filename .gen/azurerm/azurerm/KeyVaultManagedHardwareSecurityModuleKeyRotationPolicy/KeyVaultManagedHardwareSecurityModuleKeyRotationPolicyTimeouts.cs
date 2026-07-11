using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy
{
    [JsiiByValue(fqn: "azurerm.keyVaultManagedHardwareSecurityModuleKeyRotationPolicy.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeouts")]
    public class KeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeouts : azurerm.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy.IKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#create KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#delete KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#read KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#update KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
