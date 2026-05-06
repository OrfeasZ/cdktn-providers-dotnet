using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceStorageArchivalConfig
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration), fullyQualifiedName: "oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration")]
    public interface ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#active_storage_duration LogAnalyticsNamespaceStorageArchivalConfig#active_storage_duration}.</summary>
        [JsiiProperty(name: "activeStorageDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActiveStorageDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#archival_storage_duration LogAnalyticsNamespaceStorageArchivalConfig#archival_storage_duration}.</summary>
        [JsiiProperty(name: "archivalStorageDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArchivalStorageDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration), fullyQualifiedName: "oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#active_storage_duration LogAnalyticsNamespaceStorageArchivalConfig#active_storage_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "activeStorageDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActiveStorageDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_archival_config#archival_storage_duration LogAnalyticsNamespaceStorageArchivalConfig#archival_storage_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "archivalStorageDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArchivalStorageDuration
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
