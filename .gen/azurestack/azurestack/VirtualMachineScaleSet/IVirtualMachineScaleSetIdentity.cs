using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetIdentity), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetIdentity")]
    public interface IVirtualMachineScaleSetIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#type VirtualMachineScaleSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetIdentity), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetIdentity")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#type VirtualMachineScaleSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
