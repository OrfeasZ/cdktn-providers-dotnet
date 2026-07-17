using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiInterface(nativeType: typeof(IServicehookWebhookTfsGitPullRequestCreated), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreated")]
    public interface IServicehookWebhookTfsGitPullRequestCreated
    {
        /// <summary>Include only events for pull requests in a specific branch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#branch ServicehookWebhookTfs#branch}
        /// </remarks>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Branch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for pull requests created by users in a specific group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#pull_request_created_by ServicehookWebhookTfs#pull_request_created_by}
        /// </remarks>
        [JsiiProperty(name: "pullRequestCreatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PullRequestCreatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for pull requests with reviewers in a specific group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#pull_request_reviewers_contains ServicehookWebhookTfs#pull_request_reviewers_contains}
        /// </remarks>
        [JsiiProperty(name: "pullRequestReviewersContains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PullRequestReviewersContains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for pull requests in a specific repository (repository ID).</summary>
        /// <remarks>
        /// If not specified, all repositories in the project will trigger the event.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_id ServicehookWebhookTfs#repository_id}
        /// </remarks>
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicehookWebhookTfsGitPullRequestCreated), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreated")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Include only events for pull requests in a specific branch.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#branch ServicehookWebhookTfs#branch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Branch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for pull requests created by users in a specific group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#pull_request_created_by ServicehookWebhookTfs#pull_request_created_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pullRequestCreatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PullRequestCreatedBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for pull requests with reviewers in a specific group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#pull_request_reviewers_contains ServicehookWebhookTfs#pull_request_reviewers_contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pullRequestReviewersContains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PullRequestReviewersContains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for pull requests in a specific repository (repository ID).</summary>
            /// <remarks>
            /// If not specified, all repositories in the project will trigger the event.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_id ServicehookWebhookTfs#repository_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
