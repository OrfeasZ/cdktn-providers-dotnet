using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerPathRouteSet
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPathRouteSetPathRoutes), fullyQualifiedName: "oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutes")]
    public interface ILoadBalancerPathRouteSetPathRoutes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#backend_set_name LoadBalancerPathRouteSet#backend_set_name}.</summary>
        [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
        string BackendSetName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#path LoadBalancerPathRouteSet#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>path_match_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#path_match_type LoadBalancerPathRouteSet#path_match_type}
        /// </remarks>
        [JsiiProperty(name: "pathMatchType", typeJson: "{\"fqn\":\"oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType\"}")]
        oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType PathMatchType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPathRouteSetPathRoutes), fullyQualifiedName: "oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutes")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#backend_set_name LoadBalancerPathRouteSet#backend_set_name}.</summary>
            [JsiiProperty(name: "backendSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendSetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#path LoadBalancerPathRouteSet#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>path_match_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_path_route_set#path_match_type LoadBalancerPathRouteSet#path_match_type}
            /// </remarks>
            [JsiiProperty(name: "pathMatchType", typeJson: "{\"fqn\":\"oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType\"}")]
            public oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType PathMatchType
            {
                get => GetInstanceProperty<oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType>()!;
            }
        }
    }
}
