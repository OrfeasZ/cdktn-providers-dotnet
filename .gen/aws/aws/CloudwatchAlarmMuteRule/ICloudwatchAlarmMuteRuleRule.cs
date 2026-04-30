using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchAlarmMuteRule
{
    [JsiiInterface(nativeType: typeof(ICloudwatchAlarmMuteRuleRule), fullyQualifiedName: "aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleRule")]
    public interface ICloudwatchAlarmMuteRuleRule
    {
        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_alarm_mute_rule#schedule CloudwatchAlarmMuteRule#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleRuleSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Schedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchAlarmMuteRuleRule), fullyQualifiedName: "aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleRule")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchAlarmMuteRule.ICloudwatchAlarmMuteRuleRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_alarm_mute_rule#schedule CloudwatchAlarmMuteRule#schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleRuleSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Schedule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
