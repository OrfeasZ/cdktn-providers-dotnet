using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiInterface(nativeType: typeof(IServicehookWebhookTfsConfig), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsConfig")]
    public interface IServicehookWebhookTfsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The project ID that will be used for the TFS event subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#project_id ServicehookWebhookTfs#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>The URL to send HTTP POST to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#url ServicehookWebhookTfs#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>Accept untrusted SSL certificates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#accept_untrusted_certs ServicehookWebhookTfs#accept_untrusted_certs}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AcceptUntrustedCerts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Basic authentication password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#basic_auth_password ServicehookWebhookTfs#basic_auth_password}
        /// </remarks>
        [JsiiProperty(name: "basicAuthPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BasicAuthPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Basic authentication username.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#basic_auth_username ServicehookWebhookTfs#basic_auth_username}
        /// </remarks>
        [JsiiProperty(name: "basicAuthUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BasicAuthUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>build_completed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#build_completed ServicehookWebhookTfs#build_completed}
        /// </remarks>
        [JsiiProperty(name: "buildCompleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted? BuildCompleted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Detailed messages to send - all, text, html, markdown or none.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#detailed_messages_to_send ServicehookWebhookTfs#detailed_messages_to_send}
        /// </remarks>
        [JsiiProperty(name: "detailedMessagesToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DetailedMessagesToSend
        {
            get
            {
                return null;
            }
        }

        /// <summary>git_pull_request_commented block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_commented ServicehookWebhookTfs#git_pull_request_commented}
        /// </remarks>
        [JsiiProperty(name: "gitPullRequestCommented", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommented\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented? GitPullRequestCommented
        {
            get
            {
                return null;
            }
        }

        /// <summary>git_pull_request_created block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_created ServicehookWebhookTfs#git_pull_request_created}
        /// </remarks>
        [JsiiProperty(name: "gitPullRequestCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreated\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated? GitPullRequestCreated
        {
            get
            {
                return null;
            }
        }

        /// <summary>git_pull_request_merge_attempted block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_merge_attempted ServicehookWebhookTfs#git_pull_request_merge_attempted}
        /// </remarks>
        [JsiiProperty(name: "gitPullRequestMergeAttempted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttempted\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted? GitPullRequestMergeAttempted
        {
            get
            {
                return null;
            }
        }

        /// <summary>git_pull_request_updated block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_updated ServicehookWebhookTfs#git_pull_request_updated}
        /// </remarks>
        [JsiiProperty(name: "gitPullRequestUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestUpdated\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestUpdated? GitPullRequestUpdated
        {
            get
            {
                return null;
            }
        }

        /// <summary>git_push block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_push ServicehookWebhookTfs#git_push}
        /// </remarks>
        [JsiiProperty(name: "gitPush", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPush\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPush? GitPush
        {
            get
            {
                return null;
            }
        }

        /// <summary>HTTP headers as key-value pairs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#http_headers ServicehookWebhookTfs#http_headers}
        /// </remarks>
        [JsiiProperty(name: "httpHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? HttpHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#id ServicehookWebhookTfs#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resource details to send - all, text, html, markdown or none.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#messages_to_send ServicehookWebhookTfs#messages_to_send}
        /// </remarks>
        [JsiiProperty(name: "messagesToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessagesToSend
        {
            get
            {
                return null;
            }
        }

        /// <summary>repository_created block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_created ServicehookWebhookTfs#repository_created}
        /// </remarks>
        [JsiiProperty(name: "repositoryCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryCreated\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryCreated? RepositoryCreated
        {
            get
            {
                return null;
            }
        }

        /// <summary>repository_deleted block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_deleted ServicehookWebhookTfs#repository_deleted}
        /// </remarks>
        [JsiiProperty(name: "repositoryDeleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryDeleted\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryDeleted? RepositoryDeleted
        {
            get
            {
                return null;
            }
        }

        /// <summary>repository_forked block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_forked ServicehookWebhookTfs#repository_forked}
        /// </remarks>
        [JsiiProperty(name: "repositoryForked", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryForked\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryForked? RepositoryForked
        {
            get
            {
                return null;
            }
        }

        /// <summary>repository_renamed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_renamed ServicehookWebhookTfs#repository_renamed}
        /// </remarks>
        [JsiiProperty(name: "repositoryRenamed", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamed\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed? RepositoryRenamed
        {
            get
            {
                return null;
            }
        }

        /// <summary>repository_status_changed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_status_changed ServicehookWebhookTfs#repository_status_changed}
        /// </remarks>
        [JsiiProperty(name: "repositoryStatusChanged", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryStatusChanged\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryStatusChanged? RepositoryStatusChanged
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resource details to send - all, minimal, or none.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#resource_details_to_send ServicehookWebhookTfs#resource_details_to_send}
        /// </remarks>
        [JsiiProperty(name: "resourceDetailsToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceDetailsToSend
        {
            get
            {
                return null;
            }
        }

        /// <summary>The resource version for the webhook subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#resource_version ServicehookWebhookTfs#resource_version}
        /// </remarks>
        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_connection_created block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#service_connection_created ServicehookWebhookTfs#service_connection_created}
        /// </remarks>
        [JsiiProperty(name: "serviceConnectionCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionCreated\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionCreated? ServiceConnectionCreated
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_connection_updated block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#service_connection_updated ServicehookWebhookTfs#service_connection_updated}
        /// </remarks>
        [JsiiProperty(name: "serviceConnectionUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdated\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated? ServiceConnectionUpdated
        {
            get
            {
                return null;
            }
        }

        /// <summary>tfvc_checkin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#tfvc_checkin ServicehookWebhookTfs#tfvc_checkin}
        /// </remarks>
        [JsiiProperty(name: "tfvcCheckin", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin? TfvcCheckin
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#timeouts ServicehookWebhookTfs#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_item_commented block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_commented ServicehookWebhookTfs#work_item_commented}
        /// </remarks>
        [JsiiProperty(name: "workItemCommented", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommented\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented? WorkItemCommented
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_item_created block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_created ServicehookWebhookTfs#work_item_created}
        /// </remarks>
        [JsiiProperty(name: "workItemCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCreated\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCreated? WorkItemCreated
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_item_deleted block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_deleted ServicehookWebhookTfs#work_item_deleted}
        /// </remarks>
        [JsiiProperty(name: "workItemDeleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeleted\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted? WorkItemDeleted
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_item_restored block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_restored ServicehookWebhookTfs#work_item_restored}
        /// </remarks>
        [JsiiProperty(name: "workItemRestored", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemRestored\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemRestored? WorkItemRestored
        {
            get
            {
                return null;
            }
        }

        /// <summary>work_item_updated block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_updated ServicehookWebhookTfs#work_item_updated}
        /// </remarks>
        [JsiiProperty(name: "workItemUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdated\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated? WorkItemUpdated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicehookWebhookTfsConfig), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The project ID that will be used for the TFS event subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#project_id ServicehookWebhookTfs#project_id}
            /// </remarks>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The URL to send HTTP POST to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#url ServicehookWebhookTfs#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Accept untrusted SSL certificates.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#accept_untrusted_certs ServicehookWebhookTfs#accept_untrusted_certs}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AcceptUntrustedCerts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Basic authentication password.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#basic_auth_password ServicehookWebhookTfs#basic_auth_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "basicAuthPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BasicAuthPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Basic authentication username.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#basic_auth_username ServicehookWebhookTfs#basic_auth_username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "basicAuthUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BasicAuthUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>build_completed block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#build_completed ServicehookWebhookTfs#build_completed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildCompleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted? BuildCompleted
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted?>();
            }

            /// <summary>Detailed messages to send - all, text, html, markdown or none.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#detailed_messages_to_send ServicehookWebhookTfs#detailed_messages_to_send}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "detailedMessagesToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DetailedMessagesToSend
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>git_pull_request_commented block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_commented ServicehookWebhookTfs#git_pull_request_commented}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitPullRequestCommented", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommented\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented? GitPullRequestCommented
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented?>();
            }

            /// <summary>git_pull_request_created block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_created ServicehookWebhookTfs#git_pull_request_created}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitPullRequestCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreated\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated? GitPullRequestCreated
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated?>();
            }

            /// <summary>git_pull_request_merge_attempted block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_merge_attempted ServicehookWebhookTfs#git_pull_request_merge_attempted}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitPullRequestMergeAttempted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttempted\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted? GitPullRequestMergeAttempted
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted?>();
            }

            /// <summary>git_pull_request_updated block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_updated ServicehookWebhookTfs#git_pull_request_updated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitPullRequestUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestUpdated\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestUpdated? GitPullRequestUpdated
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestUpdated?>();
            }

            /// <summary>git_push block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_push ServicehookWebhookTfs#git_push}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitPush", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPush\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPush? GitPush
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPush?>();
            }

            /// <summary>HTTP headers as key-value pairs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#http_headers ServicehookWebhookTfs#http_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? HttpHeaders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#id ServicehookWebhookTfs#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Resource details to send - all, text, html, markdown or none.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#messages_to_send ServicehookWebhookTfs#messages_to_send}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "messagesToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessagesToSend
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>repository_created block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_created ServicehookWebhookTfs#repository_created}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryCreated\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryCreated? RepositoryCreated
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryCreated?>();
            }

            /// <summary>repository_deleted block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_deleted ServicehookWebhookTfs#repository_deleted}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryDeleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryDeleted\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryDeleted? RepositoryDeleted
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryDeleted?>();
            }

            /// <summary>repository_forked block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_forked ServicehookWebhookTfs#repository_forked}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryForked", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryForked\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryForked? RepositoryForked
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryForked?>();
            }

            /// <summary>repository_renamed block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_renamed ServicehookWebhookTfs#repository_renamed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryRenamed", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamed\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed? RepositoryRenamed
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed?>();
            }

            /// <summary>repository_status_changed block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_status_changed ServicehookWebhookTfs#repository_status_changed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryStatusChanged", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryStatusChanged\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryStatusChanged? RepositoryStatusChanged
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryStatusChanged?>();
            }

            /// <summary>Resource details to send - all, minimal, or none.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#resource_details_to_send ServicehookWebhookTfs#resource_details_to_send}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceDetailsToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceDetailsToSend
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The resource version for the webhook subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#resource_version ServicehookWebhookTfs#resource_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>service_connection_created block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#service_connection_created ServicehookWebhookTfs#service_connection_created}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceConnectionCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionCreated\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionCreated? ServiceConnectionCreated
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionCreated?>();
            }

            /// <summary>service_connection_updated block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#service_connection_updated ServicehookWebhookTfs#service_connection_updated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceConnectionUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdated\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated? ServiceConnectionUpdated
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated?>();
            }

            /// <summary>tfvc_checkin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#tfvc_checkin ServicehookWebhookTfs#tfvc_checkin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tfvcCheckin", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckin\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin? TfvcCheckin
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#timeouts ServicehookWebhookTfs#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTimeouts\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTimeouts?>();
            }

            /// <summary>work_item_commented block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_commented ServicehookWebhookTfs#work_item_commented}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workItemCommented", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommented\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented? WorkItemCommented
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented?>();
            }

            /// <summary>work_item_created block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_created ServicehookWebhookTfs#work_item_created}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workItemCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCreated\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCreated? WorkItemCreated
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCreated?>();
            }

            /// <summary>work_item_deleted block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_deleted ServicehookWebhookTfs#work_item_deleted}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workItemDeleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeleted\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted? WorkItemDeleted
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted?>();
            }

            /// <summary>work_item_restored block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_restored ServicehookWebhookTfs#work_item_restored}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workItemRestored", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemRestored\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemRestored? WorkItemRestored
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemRestored?>();
            }

            /// <summary>work_item_updated block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_updated ServicehookWebhookTfs#work_item_updated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workItemUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdated\"}", isOptional: true)]
            public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated? WorkItemUpdated
            {
                get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
