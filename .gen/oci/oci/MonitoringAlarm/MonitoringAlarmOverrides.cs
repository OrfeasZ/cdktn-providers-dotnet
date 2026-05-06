using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MonitoringAlarm
{
    [JsiiByValue(fqn: "oci.monitoringAlarm.MonitoringAlarmOverrides")]
    public class MonitoringAlarmOverrides : oci.MonitoringAlarm.IMonitoringAlarmOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#body MonitoringAlarm#body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Body
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#pending_duration MonitoringAlarm#pending_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PendingDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#query MonitoringAlarm#query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Query
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#rule_name MonitoringAlarm#rule_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#severity MonitoringAlarm#severity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Severity
        {
            get;
            set;
        }
    }
}
