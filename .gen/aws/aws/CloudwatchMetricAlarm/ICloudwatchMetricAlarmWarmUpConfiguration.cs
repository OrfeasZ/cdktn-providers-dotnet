using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricAlarmWarmUpConfiguration), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmWarmUpConfiguration")]
    public interface ICloudwatchMetricAlarmWarmUpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/cloudwatch_metric_alarm#warm_up_period_duration_in_minutes CloudwatchMetricAlarm#warm_up_period_duration_in_minutes}.</summary>
        [JsiiProperty(name: "warmUpPeriodDurationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double WarmUpPeriodDurationInMinutes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/cloudwatch_metric_alarm#only_start_evaluating_after_warm_up_period_ends CloudwatchMetricAlarm#only_start_evaluating_after_warm_up_period_ends}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "onlyStartEvaluatingAfterWarmUpPeriodEnds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnlyStartEvaluatingAfterWarmUpPeriodEnds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricAlarmWarmUpConfiguration), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmWarmUpConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmWarmUpConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/cloudwatch_metric_alarm#warm_up_period_duration_in_minutes CloudwatchMetricAlarm#warm_up_period_duration_in_minutes}.</summary>
            [JsiiProperty(name: "warmUpPeriodDurationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double WarmUpPeriodDurationInMinutes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/cloudwatch_metric_alarm#only_start_evaluating_after_warm_up_period_ends CloudwatchMetricAlarm#only_start_evaluating_after_warm_up_period_ends}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onlyStartEvaluatingAfterWarmUpPeriodEnds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OnlyStartEvaluatingAfterWarmUpPeriodEnds
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
