using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricAlarmEvaluationCriteria), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteria")]
    public interface ICloudwatchMetricAlarmEvaluationCriteria
    {
        /// <summary>promql_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_metric_alarm#promql_criteria CloudwatchMetricAlarm#promql_criteria}
        /// </remarks>
        [JsiiProperty(name: "promqlCriteria", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria\"}")]
        aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria PromqlCriteria
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricAlarmEvaluationCriteria), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>promql_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_metric_alarm#promql_criteria CloudwatchMetricAlarm#promql_criteria}
            /// </remarks>
            [JsiiProperty(name: "promqlCriteria", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria\"}")]
            public aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria PromqlCriteria
            {
                get => GetInstanceProperty<aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria>()!;
            }
        }
    }
}
