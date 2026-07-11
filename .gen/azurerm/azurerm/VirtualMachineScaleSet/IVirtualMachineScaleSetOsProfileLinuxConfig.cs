using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetOsProfileLinuxConfig), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig")]
    public interface IVirtualMachineScaleSetOsProfileLinuxConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_machine_scale_set#disable_password_authentication VirtualMachineScaleSet#disable_password_authentication}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisablePasswordAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssh_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_machine_scale_set#ssh_keys VirtualMachineScaleSet#ssh_keys}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfigSshKeys" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sshKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigSshKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SshKeys
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetOsProfileLinuxConfig), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_machine_scale_set#disable_password_authentication VirtualMachineScaleSet#disable_password_authentication}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisablePasswordAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssh_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_machine_scale_set#ssh_keys VirtualMachineScaleSet#ssh_keys}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfigSshKeys" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sshKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigSshKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SshKeys
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
