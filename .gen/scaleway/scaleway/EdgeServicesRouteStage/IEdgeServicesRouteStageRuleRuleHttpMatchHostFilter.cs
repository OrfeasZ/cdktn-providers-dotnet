using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilter")]
    public interface IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter
    {
        /// <summary>The type of filter to match for the host path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#host_filter_type EdgeServicesRouteStage#host_filter_type}
        /// </remarks>
        [JsiiProperty(name: "hostFilterType", typeJson: "{\"primitive\":\"string\"}")]
        string HostFilterType
        {
            get;
        }

        /// <summary>The value to be matched for the host path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#value EdgeServicesRouteStage#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilter")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of filter to match for the host path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#host_filter_type EdgeServicesRouteStage#host_filter_type}
            /// </remarks>
            [JsiiProperty(name: "hostFilterType", typeJson: "{\"primitive\":\"string\"}")]
            public string HostFilterType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The value to be matched for the host path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#value EdgeServicesRouteStage#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
