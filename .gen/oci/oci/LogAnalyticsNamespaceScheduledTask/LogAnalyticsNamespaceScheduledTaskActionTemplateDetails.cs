using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetails")]
    public class LogAnalyticsNamespaceScheduledTaskActionTemplateDetails : oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_id LogAnalyticsNamespaceScheduledTask#template_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateId
        {
            get;
            set;
        }

        private object? _templateParams;

        /// <summary>template_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_scheduled_task#template_params LogAnalyticsNamespaceScheduledTask#template_params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TemplateParams
        {
            get => _templateParams;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionTemplateDetailsTemplateParams).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _templateParams = value;
            }
        }
    }
}
