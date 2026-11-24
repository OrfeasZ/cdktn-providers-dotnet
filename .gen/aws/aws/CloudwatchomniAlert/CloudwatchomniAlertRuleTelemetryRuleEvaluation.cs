using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluation")]
    public class CloudwatchomniAlertRuleTelemetryRuleEvaluation : aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#interval_seconds CloudwatchomniAlert#interval_seconds}.</summary>
        [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double IntervalSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#pending_duration_seconds CloudwatchomniAlert#pending_duration_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pendingDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PendingDurationSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#recovery_duration_seconds CloudwatchomniAlert#recovery_duration_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecoveryDurationSeconds
        {
            get;
            set;
        }
    }
}
