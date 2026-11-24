using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoData")]
    public class CloudwatchomniAlertRuleTelemetryRuleNoData : aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#treat_as CloudwatchomniAlert#treat_as}.</summary>
        [JsiiProperty(name: "treatAs", typeJson: "{\"primitive\":\"string\"}")]
        public string TreatAs
        {
            get;
            set;
        }
    }
}
