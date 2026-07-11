using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetNetworkProfileIpConfigurationPublicIpAddressConfiguration), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileIpConfigurationPublicIpAddressConfiguration")]
    public interface IVirtualMachineScaleSetNetworkProfileIpConfigurationPublicIpAddressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#domain_name_label VirtualMachineScaleSet#domain_name_label}.</summary>
        [JsiiProperty(name: "domainNameLabel", typeJson: "{\"primitive\":\"string\"}")]
        string DomainNameLabel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#idle_timeout VirtualMachineScaleSet#idle_timeout}.</summary>
        [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"number\"}")]
        double IdleTimeout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#name VirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetNetworkProfileIpConfigurationPublicIpAddressConfiguration), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileIpConfigurationPublicIpAddressConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfileIpConfigurationPublicIpAddressConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#domain_name_label VirtualMachineScaleSet#domain_name_label}.</summary>
            [JsiiProperty(name: "domainNameLabel", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainNameLabel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#idle_timeout VirtualMachineScaleSet#idle_timeout}.</summary>
            [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"number\"}")]
            public double IdleTimeout
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#name VirtualMachineScaleSet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
