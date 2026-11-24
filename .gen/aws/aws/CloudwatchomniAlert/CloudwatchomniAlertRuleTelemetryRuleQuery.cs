using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQuery")]
    public class CloudwatchomniAlertRuleTelemetryRuleQuery : aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#expression CloudwatchomniAlert#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#language CloudwatchomniAlert#language}.</summary>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public string Language
        {
            get;
            set;
        }
    }
}
