using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineScaleSetAdditionalUnattendContent), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContent")]
    public interface IWindowsVirtualMachineScaleSetAdditionalUnattendContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#content WindowsVirtualMachineScaleSet#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#setting WindowsVirtualMachineScaleSet#setting}.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
        string Setting
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineScaleSetAdditionalUnattendContent), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContent")]
        internal sealed class _Proxy : DeputyBase, azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#content WindowsVirtualMachineScaleSet#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#setting WindowsVirtualMachineScaleSet#setting}.</summary>
            [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
            public string Setting
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
