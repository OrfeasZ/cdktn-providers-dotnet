using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria")]
    public interface ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_metric_alarm#query CloudwatchMetricAlarm#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        string Query
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_metric_alarm#pending_period CloudwatchMetricAlarm#pending_period}.</summary>
        [JsiiProperty(name: "pendingPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PendingPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_metric_alarm#recovery_period CloudwatchMetricAlarm#recovery_period}.</summary>
        [JsiiProperty(name: "recoveryPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RecoveryPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_metric_alarm#query CloudwatchMetricAlarm#query}.</summary>
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
            public string Query
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_metric_alarm#pending_period CloudwatchMetricAlarm#pending_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pendingPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PendingPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_metric_alarm#recovery_period CloudwatchMetricAlarm#recovery_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RecoveryPeriod
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
