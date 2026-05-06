using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerLoadBalancerRoutingPolicy
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerLoadBalancerRoutingPolicyRules), fullyQualifiedName: "oci.loadBalancerLoadBalancerRoutingPolicy.LoadBalancerLoadBalancerRoutingPolicyRules")]
    public interface ILoadBalancerLoadBalancerRoutingPolicyRules
    {
        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#actions LoadBalancerLoadBalancerRoutingPolicy#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loadBalancerLoadBalancerRoutingPolicy.LoadBalancerLoadBalancerRoutingPolicyRulesActions\"},\"kind\":\"array\"}}]}}")]
        object Actions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#condition LoadBalancerLoadBalancerRoutingPolicy#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        string Condition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#name LoadBalancerLoadBalancerRoutingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerLoadBalancerRoutingPolicyRules), fullyQualifiedName: "oci.loadBalancerLoadBalancerRoutingPolicy.LoadBalancerLoadBalancerRoutingPolicyRules")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerLoadBalancerRoutingPolicy.ILoadBalancerLoadBalancerRoutingPolicyRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>actions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#actions LoadBalancerLoadBalancerRoutingPolicy#actions}
            /// </remarks>
            [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loadBalancerLoadBalancerRoutingPolicy.LoadBalancerLoadBalancerRoutingPolicyRulesActions\"},\"kind\":\"array\"}}]}}")]
            public object Actions
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#condition LoadBalancerLoadBalancerRoutingPolicy#condition}.</summary>
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
            public string Condition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#name LoadBalancerLoadBalancerRoutingPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
