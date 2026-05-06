using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceStorageArchivalConfig
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration")]
    public class LogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration : oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#active_storage_duration LogAnalyticsNamespaceStorageArchivalConfig#active_storage_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "activeStorageDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActiveStorageDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#archival_storage_duration LogAnalyticsNamespaceStorageArchivalConfig#archival_storage_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "archivalStorageDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArchivalStorageDuration
        {
            get;
            set;
        }
    }
}
