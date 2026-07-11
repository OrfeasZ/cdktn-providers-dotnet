using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiByValue(fqn: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeleted")]
    public class ServicehookWebhookTfsWorkItemDeleted : azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted
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
