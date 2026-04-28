using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilter")]
    public interface IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter
    {
        /// <summary>The type of filter to match for the HTTP URL path.</summary>
        /// <remarks>
        /// For now, all path filters must be written in regex and use the <c>regex</c> type
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#path_filter_type EdgeServicesRouteStage#path_filter_type}
        /// </remarks>
        [JsiiProperty(name: "pathFilterType", typeJson: "{\"primitive\":\"string\"}")]
        string PathFilterType
        {
            get;
        }

        /// <summary>The value to be matched for the HTTP URL path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#value EdgeServicesRouteStage#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilter")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of filter to match for the HTTP URL path.</summary>
            /// <remarks>
            /// For now, all path filters must be written in regex and use the <c>regex</c> type
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#path_filter_type EdgeServicesRouteStage#path_filter_type}
            /// </remarks>
            [JsiiProperty(name: "pathFilterType", typeJson: "{\"primitive\":\"string\"}")]
            public string PathFilterType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The value to be matched for the HTTP URL path.</summary>
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
