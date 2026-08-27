using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitInfrastructureNetwork")]
    public class StackHciDeploymentSettingScaleUnitInfrastructureNetwork : azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#dns_server StackHciDeploymentSetting#dns_server}.</summary>
        [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DnsServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#gateway StackHciDeploymentSetting#gateway}.</summary>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public string Gateway
        {
            get;
            set;
        }

        private object _ipPool;

        /// <summary>ip_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#ip_pool StackHciDeploymentSetting#ip_pool}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool\"},\"kind\":\"array\"}}]}}")]
        public object IpPool
        {
            get => _ipPool;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetworkIpPool).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipPool = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#subnet_mask StackHciDeploymentSetting#subnet_mask}.</summary>
        [JsiiProperty(name: "subnetMask", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetMask
        {
            get;
            set;
        }

        private object? _dhcpEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stack_hci_deployment_setting#dhcp_enabled StackHciDeploymentSetting#dhcp_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DhcpEnabled
        {
            get => _dhcpEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dhcpEnabled = value;
            }
        }
    }
}
