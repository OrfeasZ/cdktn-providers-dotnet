using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerLoadBalancerRoutingPolicy
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerLoadBalancerRoutingPolicyRulesActions), fullyQualifiedName: "oci.loadBalancerLoadBalancerRoutingPolicy.LoadBalancerLoadBalancerRoutingPolicyRulesActions")]
    public interface ILoadBalancerLoadBalancerRoutingPolicyRulesActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#backend_set_name LoadBalancerLoadBalancerRoutingPolicy#backend_set_name}.</summary>
        [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
        string BackendSetName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#name LoadBalancerLoadBalancerRoutingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerLoadBalancerRoutingPolicyRulesActions), fullyQualifiedName: "oci.loadBalancerLoadBalancerRoutingPolicy.LoadBalancerLoadBalancerRoutingPolicyRulesActions")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerLoadBalancerRoutingPolicy.ILoadBalancerLoadBalancerRoutingPolicyRulesActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer_routing_policy#backend_set_name LoadBalancerLoadBalancerRoutingPolicy#backend_set_name}.</summary>
            [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendSetName
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
