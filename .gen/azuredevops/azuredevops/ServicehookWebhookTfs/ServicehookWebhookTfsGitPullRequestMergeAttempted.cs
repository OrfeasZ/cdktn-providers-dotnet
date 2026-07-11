using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiByValue(fqn: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttempted")]
    public class ServicehookWebhookTfsGitPullRequestMergeAttempted : azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted
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

        /// <summary>Include only events for pull requests with a specific merge result.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#merge_result ServicehookWebhookTfs#merge_result}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mergeResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MergeResult
        {
            get;
            set;
        }

        /// <summary>Include only events for pull requests created by users in a specific group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#pull_request_created_by ServicehookWebhookTfs#pull_request_created_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pullRequestCreatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PullRequestCreatedBy
        {
            get;
            set;
        }

        /// <summary>Include only events for pull requests with reviewers in a specific group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#pull_request_reviewers_contains ServicehookWebhookTfs#pull_request_reviewers_contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pullRequestReviewersContains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PullRequestReviewersContains
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
