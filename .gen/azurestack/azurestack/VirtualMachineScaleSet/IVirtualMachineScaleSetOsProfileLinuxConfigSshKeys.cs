using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetOsProfileLinuxConfigSshKeys), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigSshKeys")]
    public interface IVirtualMachineScaleSetOsProfileLinuxConfigSshKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#path VirtualMachineScaleSet#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#key_data VirtualMachineScaleSet#key_data}.</summary>
        [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetOsProfileLinuxConfigSshKeys), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigSshKeys")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfigSshKeys
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#path VirtualMachineScaleSet#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#key_data VirtualMachineScaleSet#key_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyData
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
