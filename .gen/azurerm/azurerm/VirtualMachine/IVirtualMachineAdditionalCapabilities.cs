using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineAdditionalCapabilities), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineAdditionalCapabilities")]
    public interface IVirtualMachineAdditionalCapabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#ultra_ssd_enabled VirtualMachine#ultra_ssd_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ultraSsdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object UltraSsdEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineAdditionalCapabilities), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineAdditionalCapabilities")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachine.IVirtualMachineAdditionalCapabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#ultra_ssd_enabled VirtualMachine#ultra_ssd_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "ultraSsdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object UltraSsdEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
