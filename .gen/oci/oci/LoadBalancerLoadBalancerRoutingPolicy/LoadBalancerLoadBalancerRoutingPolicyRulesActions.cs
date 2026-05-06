using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerLoadBalancerRoutingPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loadBalancerLoadBalancerRoutingPolicy.LoadBalancerLoadBalancerRoutingPolicyRulesActions")]
    public class LoadBalancerLoadBalancerRoutingPolicyRulesActions : oci.LoadBalancerLoadBalancerRoutingPolicy.ILoadBalancerLoadBalancerRoutingPolicyRulesActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#backend_set_name LoadBalancerLoadBalancerRoutingPolicy#backend_set_name}.</summary>
        [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
        public string BackendSetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#name LoadBalancerLoadBalancerRoutingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
