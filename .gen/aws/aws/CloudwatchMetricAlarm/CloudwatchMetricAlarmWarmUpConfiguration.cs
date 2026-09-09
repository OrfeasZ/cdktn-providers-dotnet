using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmWarmUpConfiguration")]
    public class CloudwatchMetricAlarmWarmUpConfiguration : aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmWarmUpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/cloudwatch_metric_alarm#warm_up_period_duration_in_minutes CloudwatchMetricAlarm#warm_up_period_duration_in_minutes}.</summary>
        [JsiiProperty(name: "warmUpPeriodDurationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double WarmUpPeriodDurationInMinutes
        {
            get;
            set;
        }

        private object? _onlyStartEvaluatingAfterWarmUpPeriodEnds;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/cloudwatch_metric_alarm#only_start_evaluating_after_warm_up_period_ends CloudwatchMetricAlarm#only_start_evaluating_after_warm_up_period_ends}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onlyStartEvaluatingAfterWarmUpPeriodEnds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OnlyStartEvaluatingAfterWarmUpPeriodEnds
        {
            get => _onlyStartEvaluatingAfterWarmUpPeriodEnds;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _onlyStartEvaluatingAfterWarmUpPeriodEnds = value;
            }
        }
    }
}
