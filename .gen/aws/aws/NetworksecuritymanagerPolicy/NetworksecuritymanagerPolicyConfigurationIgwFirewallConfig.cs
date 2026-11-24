using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfig")]
    public class NetworksecuritymanagerPolicyConfigurationIgwFirewallConfig : aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#default_subnet_connectivity NetworksecuritymanagerPolicy#default_subnet_connectivity}.</summary>
        [JsiiProperty(name: "defaultSubnetConnectivity", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultSubnetConnectivity
        {
            get;
            set;
        }

        private object? _subnetConnectivityOverride;

        /// <summary>subnet_connectivity_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#subnet_connectivity_override NetworksecuritymanagerPolicy#subnet_connectivity_override}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subnetConnectivityOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SubnetConnectivityOverride
        {
            get => _subnetConnectivityOverride;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subnetConnectivityOverride = value;
            }
        }
    }
}
