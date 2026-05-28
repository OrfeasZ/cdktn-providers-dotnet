using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanReportConfiguration")]
    public class ArcregionswitchPlanReportConfiguration : aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfiguration
    {
        private object? _reportOutput;

        /// <summary>report_output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#report_output ArcregionswitchPlan#report_output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reportOutput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanReportConfigurationReportOutput\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ReportOutput
        {
            get => _reportOutput;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfigurationReportOutput[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfigurationReportOutput).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _reportOutput = value;
            }
        }
    }
}
