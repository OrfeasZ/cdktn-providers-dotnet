using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerRuleSet
{
    [JsiiByValue(fqn: "oci.loadBalancerRuleSet.LoadBalancerRuleSetItemsIpMaxConnections")]
    public class LoadBalancerRuleSetItemsIpMaxConnections : oci.LoadBalancerRuleSet.ILoadBalancerRuleSetItemsIpMaxConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#ip_addresses LoadBalancerRuleSet#ip_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#max_connections LoadBalancerRuleSet#max_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConnections
        {
            get;
            set;
        }
    }
}
