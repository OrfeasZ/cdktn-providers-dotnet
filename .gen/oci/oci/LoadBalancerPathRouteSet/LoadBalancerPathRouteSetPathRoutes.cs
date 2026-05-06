using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerPathRouteSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutes")]
    public class LoadBalancerPathRouteSetPathRoutes : oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#backend_set_name LoadBalancerPathRouteSet#backend_set_name}.</summary>
        [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
        public string BackendSetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#path LoadBalancerPathRouteSet#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>path_match_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#path_match_type LoadBalancerPathRouteSet#path_match_type}
        /// </remarks>
        [JsiiProperty(name: "pathMatchType", typeJson: "{\"fqn\":\"oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType\"}")]
        public oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType PathMatchType
        {
            get;
            set;
        }
    }
}
