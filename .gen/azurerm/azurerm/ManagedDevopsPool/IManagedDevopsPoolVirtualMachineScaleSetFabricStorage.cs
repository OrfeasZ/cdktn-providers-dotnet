using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolVirtualMachineScaleSetFabricStorage), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricStorage")]
    public interface IManagedDevopsPoolVirtualMachineScaleSetFabricStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#disk_size_in_gb ManagedDevopsPool#disk_size_in_gb}.</summary>
        [JsiiProperty(name: "diskSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double DiskSizeInGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#caching ManagedDevopsPool#caching}.</summary>
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Caching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#drive_letter ManagedDevopsPool#drive_letter}.</summary>
        [JsiiProperty(name: "driveLetter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DriveLetter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#storage_account_type ManagedDevopsPool#storage_account_type}.</summary>
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolVirtualMachineScaleSetFabricStorage), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricStorage")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#disk_size_in_gb ManagedDevopsPool#disk_size_in_gb}.</summary>
            [JsiiProperty(name: "diskSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double DiskSizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#caching ManagedDevopsPool#caching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Caching
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#drive_letter ManagedDevopsPool#drive_letter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "driveLetter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DriveLetter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#storage_account_type ManagedDevopsPool#storage_account_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
