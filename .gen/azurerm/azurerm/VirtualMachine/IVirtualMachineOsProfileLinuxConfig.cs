using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineOsProfileLinuxConfig), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfig")]
    public interface IVirtualMachineOsProfileLinuxConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#disable_password_authentication VirtualMachine#disable_password_authentication}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object DisablePasswordAuthentication
        {
            get;
        }

        /// <summary>ssh_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#ssh_keys VirtualMachine#ssh_keys}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachine.IVirtualMachineOsProfileLinuxConfigSshKeys" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sshKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfigSshKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SshKeys
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineOsProfileLinuxConfig), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachine.IVirtualMachineOsProfileLinuxConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#disable_password_authentication VirtualMachine#disable_password_authentication}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object DisablePasswordAuthentication
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>ssh_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#ssh_keys VirtualMachine#ssh_keys}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachine.IVirtualMachineOsProfileLinuxConfigSshKeys" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sshKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfigSshKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SshKeys
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
