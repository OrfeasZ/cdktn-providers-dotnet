using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchAlarmMuteRule
{
    [JsiiByValue(fqn: "aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleRule")]
    public class CloudwatchAlarmMuteRuleRule : aws.CloudwatchAlarmMuteRule.ICloudwatchAlarmMuteRuleRule
    {
        private object? _schedule;

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_alarm_mute_rule#schedule CloudwatchAlarmMuteRule#schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleRuleSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Schedule
        {
            get => _schedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchAlarmMuteRule.ICloudwatchAlarmMuteRuleRuleSchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchAlarmMuteRule.ICloudwatchAlarmMuteRuleRuleSchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schedule = value;
            }
        }
    }
}
