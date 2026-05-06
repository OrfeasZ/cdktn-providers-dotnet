using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookupsUpdateDataManagement
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceLookupsUpdateDataManagement.LogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts")]
    public class LogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts : oci.LogAnalyticsNamespaceLookupsUpdateDataManagement.ILogAnalyticsNamespaceLookupsUpdateDataManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookups_update_data_management#create LogAnalyticsNamespaceLookupsUpdateDataManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
