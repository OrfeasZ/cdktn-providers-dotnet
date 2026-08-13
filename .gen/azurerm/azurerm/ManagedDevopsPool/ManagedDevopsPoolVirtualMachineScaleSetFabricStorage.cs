using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricStorage")]
    public class ManagedDevopsPoolVirtualMachineScaleSetFabricStorage : azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_devops_pool#disk_size_in_gb ManagedDevopsPool#disk_size_in_gb}.</summary>
        [JsiiProperty(name: "diskSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double DiskSizeInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_devops_pool#caching ManagedDevopsPool#caching}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Caching
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_devops_pool#drive_letter ManagedDevopsPool#drive_letter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "driveLetter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DriveLetter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_devops_pool#storage_account_type ManagedDevopsPool#storage_account_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountType
        {
            get;
            set;
        }
    }
}
