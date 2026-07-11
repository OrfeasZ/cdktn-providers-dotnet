using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineSecret), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineSecret")]
    public interface ILinuxVirtualMachineSecret
    {
        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#certificate LinuxVirtualMachine#certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecretCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSecretCertificate\"},\"kind\":\"array\"}}]}}")]
        object Certificate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#key_vault_id LinuxVirtualMachine#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineSecret), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineSecret")]
        internal sealed class _Proxy : DeputyBase, azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#certificate LinuxVirtualMachine#certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecretCertificate" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSecretCertificate\"},\"kind\":\"array\"}}]}}")]
            public object Certificate
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#key_vault_id LinuxVirtualMachine#key_vault_id}.</summary>
            [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
