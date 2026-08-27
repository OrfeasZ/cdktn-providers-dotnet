using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiInterface(nativeType: typeof(IStackHciDeploymentSettingScaleUnitInfrastructureNetwork), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitInfrastructureNetwork")]
    public interface IStackHciDeploymentSettingScaleUnitInfrastructureNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#dns_server StackHciDeploymentSetting#dns_server}.</summary>
        [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsServer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#gateway StackHciDeploymentSetting#gateway}.</summary>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        string Gateway
        {
            get;
        }

        /// <summary>ip_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#ip_pool StackHciDeploymentSetting#ip_pool}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool\"},\"kind\":\"array\"}}]}}")]
        object IpPool
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#subnet_mask StackHciDeploymentSetting#subnet_mask}.</summary>
        [JsiiProperty(name: "subnetMask", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetMask
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#dhcp_enabled StackHciDeploymentSetting#dhcp_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "dhcpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DhcpEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciDeploymentSettingScaleUnitInfrastructureNetwork), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitInfrastructureNetwork")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#dns_server StackHciDeploymentSetting#dns_server}.</summary>
            [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsServer
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#gateway StackHciDeploymentSetting#gateway}.</summary>
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
            public string Gateway
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ip_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#ip_pool StackHciDeploymentSetting#ip_pool}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "ipPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool\"},\"kind\":\"array\"}}]}}")]
            public object IpPool
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#subnet_mask StackHciDeploymentSetting#subnet_mask}.</summary>
            [JsiiProperty(name: "subnetMask", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetMask
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#dhcp_enabled StackHciDeploymentSetting#dhcp_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dhcpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DhcpEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
