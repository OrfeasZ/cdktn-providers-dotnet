using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileLoadBalancerProfile")]
    public class RedhatOpenshiftClusterNetworkProfileLoadBalancerProfile : azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#managed_outbound_ip_count RedhatOpenshiftCluster#managed_outbound_ip_count}.</summary>
        [JsiiProperty(name: "managedOutboundIpCount", typeJson: "{\"primitive\":\"number\"}")]
        public double ManagedOutboundIpCount
        {
            get;
            set;
        }
    }
}
