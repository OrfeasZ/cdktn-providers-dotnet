using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerPolicy
{
    [JsiiInterface(nativeType: typeof(INetworksecuritymanagerPolicyConfigurationIgwFirewallConfig), fullyQualifiedName: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfig")]
    public interface INetworksecuritymanagerPolicyConfigurationIgwFirewallConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#default_subnet_connectivity NetworksecuritymanagerPolicy#default_subnet_connectivity}.</summary>
        [JsiiProperty(name: "defaultSubnetConnectivity", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultSubnetConnectivity
        {
            get;
        }

        /// <summary>subnet_connectivity_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#subnet_connectivity_override NetworksecuritymanagerPolicy#subnet_connectivity_override}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "subnetConnectivityOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubnetConnectivityOverride
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworksecuritymanagerPolicyConfigurationIgwFirewallConfig), fullyQualifiedName: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfig")]
        internal sealed class _Proxy : DeputyBase, aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#default_subnet_connectivity NetworksecuritymanagerPolicy#default_subnet_connectivity}.</summary>
            [JsiiProperty(name: "defaultSubnetConnectivity", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultSubnetConnectivity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>subnet_connectivity_override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#subnet_connectivity_override NetworksecuritymanagerPolicy#subnet_connectivity_override}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subnetConnectivityOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SubnetConnectivityOverride
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
