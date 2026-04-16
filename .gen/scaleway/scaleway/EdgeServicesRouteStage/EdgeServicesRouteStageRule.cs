using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    [JsiiByValue(fqn: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRule")]
    public class EdgeServicesRouteStageRule : scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRule
    {
        /// <summary>ID of the backend stage that requests matching the rule should be forwarded to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_route_stage#backend_stage_id EdgeServicesRouteStage#backend_stage_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackendStageId
        {
            get;
            set;
        }

        /// <summary>rule_http_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_route_stage#rule_http_match EdgeServicesRouteStage#rule_http_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleHttpMatch", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatch\"}", isOptional: true)]
        public scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch? RuleHttpMatch
        {
            get;
            set;
        }

        /// <summary>ID of the WAF stage that requests matching the rule should be forwarded to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_route_stage#waf_stage_id EdgeServicesRouteStage#waf_stage_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wafStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WafStageId
        {
            get;
            set;
        }
    }
}
