using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchAlarmMuteRule
{
    [JsiiInterface(nativeType: typeof(ICloudwatchAlarmMuteRuleMuteTargets), fullyQualifiedName: "aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleMuteTargets")]
    public interface ICloudwatchAlarmMuteRuleMuteTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_alarm_mute_rule#alarm_names CloudwatchAlarmMuteRule#alarm_names}.</summary>
        [JsiiProperty(name: "alarmNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AlarmNames
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchAlarmMuteRuleMuteTargets), fullyQualifiedName: "aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleMuteTargets")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchAlarmMuteRule.ICloudwatchAlarmMuteRuleMuteTargets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_alarm_mute_rule#alarm_names CloudwatchAlarmMuteRule#alarm_names}.</summary>
            [JsiiProperty(name: "alarmNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AlarmNames
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
