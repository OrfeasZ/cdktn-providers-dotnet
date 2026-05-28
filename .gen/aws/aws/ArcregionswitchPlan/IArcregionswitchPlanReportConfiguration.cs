using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanReportConfiguration), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanReportConfiguration")]
    public interface IArcregionswitchPlanReportConfiguration
    {
        /// <summary>report_output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#report_output ArcregionswitchPlan#report_output}
        /// </remarks>
        [JsiiProperty(name: "reportOutput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanReportConfigurationReportOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReportOutput
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanReportConfiguration), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanReportConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>report_output block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#report_output ArcregionswitchPlan#report_output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reportOutput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanReportConfigurationReportOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ReportOutput
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
