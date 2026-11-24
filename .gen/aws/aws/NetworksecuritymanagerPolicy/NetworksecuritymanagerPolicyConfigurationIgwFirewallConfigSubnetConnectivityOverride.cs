using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride")]
    public class NetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride : aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyConfigurationIgwFirewallConfigSubnetConnectivityOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#connectivity_type NetworksecuritymanagerPolicy#connectivity_type}.</summary>
        [JsiiProperty(name: "connectivityType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectivityType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/networksecuritymanager_policy#scope_arn NetworksecuritymanagerPolicy#scope_arn}.</summary>
        [JsiiProperty(name: "scopeArn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ScopeArn
        {
            get;
            set;
        }
    }
}
