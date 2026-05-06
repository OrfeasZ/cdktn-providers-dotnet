using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookupsAppendDataManagement
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceLookupsAppendDataManagement.LogAnalyticsNamespaceLookupsAppendDataManagementTimeouts")]
    public class LogAnalyticsNamespaceLookupsAppendDataManagementTimeouts : oci.LogAnalyticsNamespaceLookupsAppendDataManagement.ILogAnalyticsNamespaceLookupsAppendDataManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_append_data_management#create LogAnalyticsNamespaceLookupsAppendDataManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
