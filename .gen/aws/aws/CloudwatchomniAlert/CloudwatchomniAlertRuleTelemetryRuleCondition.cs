using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleCondition")]
    public class CloudwatchomniAlertRuleTelemetryRuleCondition : aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#comparator CloudwatchomniAlert#comparator}.</summary>
        [JsiiProperty(name: "comparator", typeJson: "{\"primitive\":\"string\"}")]
        public string Comparator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#threshold_mode CloudwatchomniAlert#threshold_mode}.</summary>
        [JsiiProperty(name: "thresholdMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ThresholdMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#critical_threshold CloudwatchomniAlert#critical_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "criticalThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CriticalThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#threshold_field CloudwatchomniAlert#threshold_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThresholdField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#warning_threshold CloudwatchomniAlert#warning_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warningThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WarningThreshold
        {
            get;
            set;
        }
    }
}
