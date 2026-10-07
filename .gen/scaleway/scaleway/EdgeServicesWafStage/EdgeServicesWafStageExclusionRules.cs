using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesWafStage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.edgeServicesWafStage.EdgeServicesWafStageExclusionRules")]
    public class EdgeServicesWafStageExclusionRules : scaleway.EdgeServicesWafStage.IEdgeServicesWafStageExclusionRules
    {
        /// <summary>OWASP CRS rule ID excluded from the WAF.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/edge_services_waf_stage#rule_id EdgeServicesWafStage#rule_id}
        /// </remarks>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"number\"}")]
        public double RuleId
        {
            get;
            set;
        }
    }
}
