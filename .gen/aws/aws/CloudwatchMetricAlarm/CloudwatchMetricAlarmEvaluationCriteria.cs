using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteria")]
    public class CloudwatchMetricAlarmEvaluationCriteria : aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteria
    {
        /// <summary>promql_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_metric_alarm#promql_criteria CloudwatchMetricAlarm#promql_criteria}
        /// </remarks>
        [JsiiProperty(name: "promqlCriteria", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria\"}")]
        public aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria PromqlCriteria
        {
            get;
            set;
        }
    }
}
