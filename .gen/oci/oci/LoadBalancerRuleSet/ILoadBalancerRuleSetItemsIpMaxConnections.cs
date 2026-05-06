using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerRuleSet
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerRuleSetItemsIpMaxConnections), fullyQualifiedName: "oci.loadBalancerRuleSet.LoadBalancerRuleSetItemsIpMaxConnections")]
    public interface ILoadBalancerRuleSetItemsIpMaxConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#ip_addresses LoadBalancerRuleSet#ip_addresses}.</summary>
        [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#max_connections LoadBalancerRuleSet#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConnections
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerRuleSetItemsIpMaxConnections), fullyQualifiedName: "oci.loadBalancerRuleSet.LoadBalancerRuleSetItemsIpMaxConnections")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerRuleSet.ILoadBalancerRuleSetItemsIpMaxConnections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#ip_addresses LoadBalancerRuleSet#ip_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#max_connections LoadBalancerRuleSet#max_connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConnections
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
