using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicatedVm
{
    [JsiiByValue(fqn: "azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmNetworkInterface")]
    public class SiteRecoveryReplicatedVmNetworkInterface : azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterface
    {
        private object? _ipConfiguration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/site_recovery_replicated_vm#ip_configuration SiteRecoveryReplicatedVm#ip_configuration}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterfaceIpConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmNetworkInterfaceIpConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpConfiguration
        {
            get => _ipConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterfaceIpConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterfaceIpConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/site_recovery_replicated_vm#source_network_interface_id SiteRecoveryReplicatedVm#source_network_interface_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceNetworkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceNetworkInterfaceId
        {
            get;
            set;
        }
    }
}
