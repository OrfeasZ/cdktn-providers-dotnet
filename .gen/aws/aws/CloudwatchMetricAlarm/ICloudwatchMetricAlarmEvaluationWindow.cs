using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricAlarmEvaluationWindow), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindow")]
    public interface ICloudwatchMetricAlarmEvaluationWindow
    {
        /// <summary>wall_clock_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/cloudwatch_metric_alarm#wall_clock_window CloudwatchMetricAlarm#wall_clock_window}
        /// </remarks>
        [JsiiProperty(name: "wallClockWindow", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindow\"}")]
        aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow WallClockWindow
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricAlarmEvaluationWindow), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindow")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>wall_clock_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/cloudwatch_metric_alarm#wall_clock_window CloudwatchMetricAlarm#wall_clock_window}
            /// </remarks>
            [JsiiProperty(name: "wallClockWindow", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindow\"}")]
            public aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow WallClockWindow
            {
                get => GetInstanceProperty<aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow>()!;
            }
        }
    }
}
