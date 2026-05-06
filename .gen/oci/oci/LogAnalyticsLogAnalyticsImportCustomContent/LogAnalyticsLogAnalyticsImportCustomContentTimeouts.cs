using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsImportCustomContent
{
    [JsiiByValue(fqn: "oci.logAnalyticsLogAnalyticsImportCustomContent.LogAnalyticsLogAnalyticsImportCustomContentTimeouts")]
    public class LogAnalyticsLogAnalyticsImportCustomContentTimeouts : oci.LogAnalyticsLogAnalyticsImportCustomContent.ILogAnalyticsLogAnalyticsImportCustomContentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_import_custom_content#create LogAnalyticsLogAnalyticsImportCustomContent#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_import_custom_content#delete LogAnalyticsLogAnalyticsImportCustomContent#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_import_custom_content#update LogAnalyticsLogAnalyticsImportCustomContent#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
