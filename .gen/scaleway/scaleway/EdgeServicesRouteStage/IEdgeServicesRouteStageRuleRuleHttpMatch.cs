using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesRouteStageRuleRuleHttpMatch), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatch")]
    public interface IEdgeServicesRouteStageRuleRuleHttpMatch
    {
        /// <summary>host_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#host_filter EdgeServicesRouteStage#host_filter}
        /// </remarks>
        [JsiiProperty(name: "hostFilter", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter? HostFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>HTTP methods to filter for.</summary>
        /// <remarks>
        /// A request using any of these methods will be considered to match the rule. Possible values are <c>get</c>, <c>post</c>, <c>put</c>, <c>patch</c>, <c>delete</c>, <c>head</c>, <c>options</c>. All methods will match if none is provided
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#method_filters EdgeServicesRouteStage#method_filters}
        /// </remarks>
        [JsiiProperty(name: "methodFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MethodFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#path_filter EdgeServicesRouteStage#path_filter}
        /// </remarks>
        [JsiiProperty(name: "pathFilter", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter? PathFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesRouteStageRuleRuleHttpMatch), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatch")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>host_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#host_filter EdgeServicesRouteStage#host_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostFilter", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilter\"}", isOptional: true)]
            public scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter? HostFilter
            {
                get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter?>();
            }

            /// <summary>HTTP methods to filter for.</summary>
            /// <remarks>
            /// A request using any of these methods will be considered to match the rule. Possible values are <c>get</c>, <c>post</c>, <c>put</c>, <c>patch</c>, <c>delete</c>, <c>head</c>, <c>options</c>. All methods will match if none is provided
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#method_filters EdgeServicesRouteStage#method_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "methodFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MethodFilters
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>path_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#path_filter EdgeServicesRouteStage#path_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathFilter", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilter\"}", isOptional: true)]
            public scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter? PathFilter
            {
                get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter?>();
            }
        }
    }
}
