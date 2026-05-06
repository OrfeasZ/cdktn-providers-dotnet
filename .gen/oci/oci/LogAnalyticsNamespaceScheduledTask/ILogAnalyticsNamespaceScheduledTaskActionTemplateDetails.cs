using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetails")]
    public interface ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_id LogAnalyticsNamespaceScheduledTask#template_id}.</summary>
        [JsiiProperty(name: "templateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TemplateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>template_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_params LogAnalyticsNamespaceScheduledTask#template_params}
        /// </remarks>
        [JsiiProperty(name: "templateParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TemplateParams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetails")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_id LogAnalyticsNamespaceScheduledTask#template_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "templateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TemplateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>template_params block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_params LogAnalyticsNamespaceScheduledTask#template_params}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "templateParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TemplateParams
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
