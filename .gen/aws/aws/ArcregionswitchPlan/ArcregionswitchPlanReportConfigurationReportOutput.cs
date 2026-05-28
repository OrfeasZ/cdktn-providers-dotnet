using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanReportConfigurationReportOutput")]
    public class ArcregionswitchPlanReportConfigurationReportOutput : aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfigurationReportOutput
    {
        private object? _s3Configuration;

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#s3_configuration ArcregionswitchPlan#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanReportConfigurationReportOutputS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Configuration
        {
            get => _s3Configuration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfigurationReportOutputS3Configuration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfigurationReportOutputS3Configuration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3Configuration = value;
            }
        }
    }
}
