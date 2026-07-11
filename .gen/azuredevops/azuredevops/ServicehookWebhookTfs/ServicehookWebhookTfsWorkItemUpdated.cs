using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiByValue(fqn: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdated")]
    public class ServicehookWebhookTfsWorkItemUpdated : azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated
    {
        /// <summary>Include only events for work items under a specific area path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#area_path ServicehookWebhookTfs#area_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "areaPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AreaPath
        {
            get;
            set;
        }

        /// <summary>Include only events for work items with a change in a specific field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#changed_fields ServicehookWebhookTfs#changed_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "changedFields", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ChangedFields
        {
            get;
            set;
        }

        private object? _linksChanged;

        /// <summary>Include only events for work items with one or more links added or removed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#links_changed ServicehookWebhookTfs#links_changed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linksChanged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? LinksChanged
        {
            get => _linksChanged;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _linksChanged = value;
            }
        }

        /// <summary>Include only events for work items that contain a specific tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#tag ServicehookWebhookTfs#tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tag
        {
            get;
            set;
        }

        /// <summary>Include only events for work items of a specific type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#work_item_type ServicehookWebhookTfs#work_item_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workItemType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkItemType
        {
            get;
            set;
        }
    }
}
