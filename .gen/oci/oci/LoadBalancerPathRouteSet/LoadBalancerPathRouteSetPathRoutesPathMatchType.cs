using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerPathRouteSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType")]
    public class LoadBalancerPathRouteSetPathRoutesPathMatchType : oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#match_type LoadBalancerPathRouteSet#match_type}.</summary>
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchType
        {
            get;
            set;
        }
    }
}
