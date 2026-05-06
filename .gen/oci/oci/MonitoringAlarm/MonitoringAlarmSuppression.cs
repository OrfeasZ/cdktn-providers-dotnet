using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MonitoringAlarm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.monitoringAlarm.MonitoringAlarmSuppression")]
    public class MonitoringAlarmSuppression : oci.MonitoringAlarm.IMonitoringAlarmSuppression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#time_suppress_from MonitoringAlarm#time_suppress_from}.</summary>
        [JsiiProperty(name: "timeSuppressFrom", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeSuppressFrom
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#time_suppress_until MonitoringAlarm#time_suppress_until}.</summary>
        [JsiiProperty(name: "timeSuppressUntil", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeSuppressUntil
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#description MonitoringAlarm#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
