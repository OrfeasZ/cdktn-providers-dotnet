using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MonitoringAlarmSuppression
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.monitoringAlarmSuppression.MonitoringAlarmSuppressionSuppressionConditions")]
    public class MonitoringAlarmSuppressionSuppressionConditions : oci.MonitoringAlarmSuppression.IMonitoringAlarmSuppressionSuppressionConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#condition_type MonitoringAlarmSuppressionA#condition_type}.</summary>
        [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConditionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#suppression_duration MonitoringAlarmSuppressionA#suppression_duration}.</summary>
        [JsiiProperty(name: "suppressionDuration", typeJson: "{\"primitive\":\"string\"}")]
        public string SuppressionDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#suppression_recurrence MonitoringAlarmSuppressionA#suppression_recurrence}.</summary>
        [JsiiProperty(name: "suppressionRecurrence", typeJson: "{\"primitive\":\"string\"}")]
        public string SuppressionRecurrence
        {
            get;
            set;
        }
    }
}
