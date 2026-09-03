using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetBootDiagnostics), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics")]
    public interface IVirtualMachineScaleSetBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#storage_uri VirtualMachineScaleSet#storage_uri}.</summary>
        [JsiiProperty(name: "storageUri", typeJson: "{\"primitive\":\"string\"}")]
        string StorageUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#enabled VirtualMachineScaleSet#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetBootDiagnostics), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#storage_uri VirtualMachineScaleSet#storage_uri}.</summary>
            [JsiiProperty(name: "storageUri", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#enabled VirtualMachineScaleSet#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
