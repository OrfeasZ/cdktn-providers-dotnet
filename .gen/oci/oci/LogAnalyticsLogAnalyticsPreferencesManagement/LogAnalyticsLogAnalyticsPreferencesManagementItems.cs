using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsPreferencesManagement
{
    [JsiiByValue(fqn: "oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementItems")]
    public class LogAnalyticsLogAnalyticsPreferencesManagementItems : oci.LogAnalyticsLogAnalyticsPreferencesManagement.ILogAnalyticsLogAnalyticsPreferencesManagementItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_preferences_management#name LogAnalyticsLogAnalyticsPreferencesManagement#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_preferences_management#value LogAnalyticsLogAnalyticsPreferencesManagement#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
