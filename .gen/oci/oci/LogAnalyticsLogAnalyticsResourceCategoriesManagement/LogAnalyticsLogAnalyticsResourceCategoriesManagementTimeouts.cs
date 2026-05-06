using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsResourceCategoriesManagement
{
    [JsiiByValue(fqn: "oci.logAnalyticsLogAnalyticsResourceCategoriesManagement.LogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts")]
    public class LogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts : oci.LogAnalyticsLogAnalyticsResourceCategoriesManagement.ILogAnalyticsLogAnalyticsResourceCategoriesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#create LogAnalyticsLogAnalyticsResourceCategoriesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#delete LogAnalyticsLogAnalyticsResourceCategoriesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_resource_categories_management#update LogAnalyticsLogAnalyticsResourceCategoriesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
