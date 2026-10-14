using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindow")]
    public class CloudwatchMetricAlarmEvaluationWindow : aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindow
    {
        /// <summary>wall_clock_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_metric_alarm#wall_clock_window CloudwatchMetricAlarm#wall_clock_window}
        /// </remarks>
        [JsiiProperty(name: "wallClockWindow", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindow\"}")]
        public aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow WallClockWindow
        {
            get;
            set;
        }
    }
}
