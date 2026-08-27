using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    [JsiiInterface(nativeType: typeof(IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileLoadBalancerProfile")]
    public interface IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#managed_outbound_ip_count RedhatOpenshiftCluster#managed_outbound_ip_count}.</summary>
        [JsiiProperty(name: "managedOutboundIpCount", typeJson: "{\"primitive\":\"number\"}")]
        double ManagedOutboundIpCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfileLoadBalancerProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfileLoadBalancerProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#managed_outbound_ip_count RedhatOpenshiftCluster#managed_outbound_ip_count}.</summary>
            [JsiiProperty(name: "managedOutboundIpCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ManagedOutboundIpCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
