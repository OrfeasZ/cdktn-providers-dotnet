using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerPathRouteSet
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPathRouteSetPathRoutesPathMatchType), fullyQualifiedName: "oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType")]
    public interface ILoadBalancerPathRouteSetPathRoutesPathMatchType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#match_type LoadBalancerPathRouteSet#match_type}.</summary>
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
        string MatchType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPathRouteSetPathRoutesPathMatchType), fullyQualifiedName: "oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#match_type LoadBalancerPathRouteSet#match_type}.</summary>
            [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
