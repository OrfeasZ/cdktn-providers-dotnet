using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesWafStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesWafStageExclusionRules), fullyQualifiedName: "scaleway.edgeServicesWafStage.EdgeServicesWafStageExclusionRules")]
    public interface IEdgeServicesWafStageExclusionRules
    {
        /// <summary>OWASP CRS rule ID excluded from the WAF.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/edge_services_waf_stage#rule_id EdgeServicesWafStage#rule_id}
        /// </remarks>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"number\"}")]
        double RuleId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesWafStageExclusionRules), fullyQualifiedName: "scaleway.edgeServicesWafStage.EdgeServicesWafStageExclusionRules")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesWafStage.IEdgeServicesWafStageExclusionRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>OWASP CRS rule ID excluded from the WAF.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/edge_services_waf_stage#rule_id EdgeServicesWafStage#rule_id}
            /// </remarks>
            [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"number\"}")]
            public double RuleId
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
