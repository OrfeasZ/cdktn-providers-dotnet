using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiByValue(fqn: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted")]
    public class ServicehookWebhookTfsBuildCompleted : azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted
    {
        /// <summary>Include only events for completed builds that have a specific completion status.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#build_status ServicehookWebhookTfs#build_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BuildStatus
        {
            get;
            set;
        }

        /// <summary>Include only events for completed builds for a specific pipeline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#definition_name ServicehookWebhookTfs#definition_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "definitionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefinitionName
        {
            get;
            set;
        }
    }
}
