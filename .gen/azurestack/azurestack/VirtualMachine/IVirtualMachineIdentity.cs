using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineIdentity), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachineIdentity")]
    public interface IVirtualMachineIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#type VirtualMachine#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineIdentity), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachineIdentity")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachine.IVirtualMachineIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#type VirtualMachine#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
