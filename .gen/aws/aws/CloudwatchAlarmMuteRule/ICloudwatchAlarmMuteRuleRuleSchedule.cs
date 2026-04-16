using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchAlarmMuteRule
{
    [JsiiInterface(nativeType: typeof(ICloudwatchAlarmMuteRuleRuleSchedule), fullyQualifiedName: "aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleRuleSchedule")]
    public interface ICloudwatchAlarmMuteRuleRuleSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_alarm_mute_rule#duration CloudwatchAlarmMuteRule#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        string Duration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_alarm_mute_rule#expression CloudwatchAlarmMuteRule#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_alarm_mute_rule#timezone CloudwatchAlarmMuteRule#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timezone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchAlarmMuteRuleRuleSchedule), fullyQualifiedName: "aws.cloudwatchAlarmMuteRule.CloudwatchAlarmMuteRuleRuleSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchAlarmMuteRule.ICloudwatchAlarmMuteRuleRuleSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_alarm_mute_rule#duration CloudwatchAlarmMuteRule#duration}.</summary>
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
            public string Duration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_alarm_mute_rule#expression CloudwatchAlarmMuteRule#expression}.</summary>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_alarm_mute_rule#timezone CloudwatchAlarmMuteRule#timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timezone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
