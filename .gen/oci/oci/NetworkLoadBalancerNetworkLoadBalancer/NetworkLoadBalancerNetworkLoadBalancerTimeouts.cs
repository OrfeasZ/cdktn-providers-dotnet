using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkLoadBalancerNetworkLoadBalancer
{
    [JsiiByValue(fqn: "oci.networkLoadBalancerNetworkLoadBalancer.NetworkLoadBalancerNetworkLoadBalancerTimeouts")]
    public class NetworkLoadBalancerNetworkLoadBalancerTimeouts : oci.NetworkLoadBalancerNetworkLoadBalancer.INetworkLoadBalancerNetworkLoadBalancerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancer#create NetworkLoadBalancerNetworkLoadBalancer#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancer#delete NetworkLoadBalancerNetworkLoadBalancer#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_network_load_balancer#update NetworkLoadBalancerNetworkLoadBalancer#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
