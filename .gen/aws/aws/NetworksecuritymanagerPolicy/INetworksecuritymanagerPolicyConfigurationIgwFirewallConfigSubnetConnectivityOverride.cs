using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerPolicy
{
    [JsiiInterface(nativeType: typeof(INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride), fullyQualifiedName: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride")]
    public interface INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#connectivity_type NetworksecuritymanagerPolicy#connectivity_type}.</summary>
        [JsiiProperty(name: "connectivityType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectivityType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#scope_arn NetworksecuritymanagerPolicy#scope_arn}.</summary>
        [JsiiProperty(name: "scopeArn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ScopeArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride), fullyQualifiedName: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride")]
        internal sealed class _Proxy : DeputyBase, aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#connectivity_type NetworksecuritymanagerPolicy#connectivity_type}.</summary>
            [JsiiProperty(name: "connectivityType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectivityType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#scope_arn NetworksecuritymanagerPolicy#scope_arn}.</summary>
            [JsiiProperty(name: "scopeArn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ScopeArn
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
