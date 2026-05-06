using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams")]
    public class LogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams : oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#key_field LogAnalyticsNamespaceScheduledTask#key_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#value_field LogAnalyticsNamespaceScheduledTask#value_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "valueField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValueField
        {
            get;
            set;
        }
    }
}
