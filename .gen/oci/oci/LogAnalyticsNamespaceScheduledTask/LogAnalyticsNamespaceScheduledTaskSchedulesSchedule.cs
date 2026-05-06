using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskSchedulesSchedule")]
    public class LogAnalyticsNamespaceScheduledTaskSchedulesSchedule : oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskSchedulesSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#type LogAnalyticsNamespaceScheduledTask#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#expression LogAnalyticsNamespaceScheduledTask#expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#misfire_policy LogAnalyticsNamespaceScheduledTask#misfire_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "misfirePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MisfirePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#recurring_interval LogAnalyticsNamespaceScheduledTask#recurring_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recurringInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecurringInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#repeat_count LogAnalyticsNamespaceScheduledTask#repeat_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repeatCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RepeatCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#time_zone LogAnalyticsNamespaceScheduledTask#time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }
    }
}
