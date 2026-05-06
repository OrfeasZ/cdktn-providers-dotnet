using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams")]
    public interface ILogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#key_field LogAnalyticsNamespaceScheduledTask#key_field}.</summary>
        [JsiiProperty(name: "keyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#value_field LogAnalyticsNamespaceScheduledTask#value_field}.</summary>
        [JsiiProperty(name: "valueField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValueField
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#key_field LogAnalyticsNamespaceScheduledTask#key_field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyField
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#value_field LogAnalyticsNamespaceScheduledTask#value_field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "valueField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValueField
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
