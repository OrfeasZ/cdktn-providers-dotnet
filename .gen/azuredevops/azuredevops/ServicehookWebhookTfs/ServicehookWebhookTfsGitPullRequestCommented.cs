using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiByValue(fqn: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommented")]
    public class ServicehookWebhookTfsGitPullRequestCommented : azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented
    {
        /// <summary>Include only events for pull requests in a specific branch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#branch ServicehookWebhookTfs#branch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Branch
        {
            get;
            set;
        }

        /// <summary>Include only events for pull requests in a specific repository (repository ID).</summary>
        /// <remarks>
        /// If not specified, all repositories in the project will trigger the event.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#repository_id ServicehookWebhookTfs#repository_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryId
        {
            get;
            set;
        }
    }
}
