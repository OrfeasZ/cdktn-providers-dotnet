using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceStorageEnableDisableArchiving
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceStorageEnableDisableArchiving.LogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts")]
    public class LogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts : oci.LogAnalyticsNamespaceStorageEnableDisableArchiving.ILogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#create LogAnalyticsNamespaceStorageEnableDisableArchiving#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#delete LogAnalyticsNamespaceStorageEnableDisableArchiving#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#update LogAnalyticsNamespaceStorageEnableDisableArchiving#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
