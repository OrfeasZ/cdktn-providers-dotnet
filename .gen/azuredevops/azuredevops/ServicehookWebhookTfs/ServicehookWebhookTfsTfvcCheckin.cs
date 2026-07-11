using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckin")]
    public class ServicehookWebhookTfsTfvcCheckin : azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin
    {
        /// <summary>Include only events for check-ins that change files under a specific path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#path ServicehookWebhookTfs#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
