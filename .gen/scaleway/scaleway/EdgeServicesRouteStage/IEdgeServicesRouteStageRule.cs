using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesRouteStageRule), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRule")]
    public interface IEdgeServicesRouteStageRule
    {
        /// <summary>ID of the backend stage that requests matching the rule should be forwarded to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#backend_stage_id EdgeServicesRouteStage#backend_stage_id}
        /// </remarks>
        [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackendStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule_http_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#rule_http_match EdgeServicesRouteStage#rule_http_match}
        /// </remarks>
        [JsiiProperty(name: "ruleHttpMatch", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch? RuleHttpMatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the WAF stage that requests matching the rule should be forwarded to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#waf_stage_id EdgeServicesRouteStage#waf_stage_id}
        /// </remarks>
        [JsiiProperty(name: "wafStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WafStageId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesRouteStageRule), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRule")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the backend stage that requests matching the rule should be forwarded to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#backend_stage_id EdgeServicesRouteStage#backend_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackendStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rule_http_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#rule_http_match EdgeServicesRouteStage#rule_http_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleHttpMatch", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatch\"}", isOptional: true)]
            public scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch? RuleHttpMatch
            {
                get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch?>();
            }

            /// <summary>ID of the WAF stage that requests matching the rule should be forwarded to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_route_stage#waf_stage_id EdgeServicesRouteStage#waf_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wafStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WafStageId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
