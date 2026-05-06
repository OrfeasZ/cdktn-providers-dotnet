using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceStorageEnableDisableArchiving
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts), fullyQualifiedName: "oci.logAnalyticsNamespaceStorageEnableDisableArchiving.LogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts")]
    public interface ILogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#create LogAnalyticsNamespaceStorageEnableDisableArchiving#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#delete LogAnalyticsNamespaceStorageEnableDisableArchiving#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#update LogAnalyticsNamespaceStorageEnableDisableArchiving#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts), fullyQualifiedName: "oci.logAnalyticsNamespaceStorageEnableDisableArchiving.LogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceStorageEnableDisableArchiving.ILogAnalyticsNamespaceStorageEnableDisableArchivingTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#create LogAnalyticsNamespaceStorageEnableDisableArchiving#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#delete LogAnalyticsNamespaceStorageEnableDisableArchiving#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_storage_enable_disable_archiving#update LogAnalyticsNamespaceStorageEnableDisableArchiving#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
