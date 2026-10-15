using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    [JsiiByValue(fqn: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindow")]
    public class CloudwatchMetricAlarmEvaluationWindowWallClockWindow : aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/cloudwatch_metric_alarm#timezone CloudwatchMetricAlarm#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }
    }
}
