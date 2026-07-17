using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsConfig")]
    public class ServicehookWebhookTfsConfig : azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsConfig
    {
        /// <summary>The project ID that will be used for the TFS event subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#project_id ServicehookWebhookTfs#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectId
        {
            get;
            set;
        }

        /// <summary>The URL to send HTTP POST to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#url ServicehookWebhookTfs#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        private object? _acceptUntrustedCerts;

        /// <summary>Accept untrusted SSL certificates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#accept_untrusted_certs ServicehookWebhookTfs#accept_untrusted_certs}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AcceptUntrustedCerts
        {
            get => _acceptUntrustedCerts;
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
                _acceptUntrustedCerts = value;
            }
        }

        /// <summary>Basic authentication password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#basic_auth_password ServicehookWebhookTfs#basic_auth_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "basicAuthPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BasicAuthPassword
        {
            get;
            set;
        }

        /// <summary>Basic authentication username.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#basic_auth_username ServicehookWebhookTfs#basic_auth_username}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "basicAuthUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BasicAuthUsername
        {
            get;
            set;
        }

        /// <summary>build_completed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#build_completed ServicehookWebhookTfs#build_completed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildCompleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted? BuildCompleted
        {
            get;
            set;
        }

        /// <summary>Detailed messages to send - all, text, html, markdown or none.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#detailed_messages_to_send ServicehookWebhookTfs#detailed_messages_to_send}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "detailedMessagesToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DetailedMessagesToSend
        {
            get;
            set;
        }

        /// <summary>git_pull_request_commented block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_commented ServicehookWebhookTfs#git_pull_request_commented}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitPullRequestCommented", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommented\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented? GitPullRequestCommented
        {
            get;
            set;
        }

        /// <summary>git_pull_request_created block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_created ServicehookWebhookTfs#git_pull_request_created}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitPullRequestCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreated\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated? GitPullRequestCreated
        {
            get;
            set;
        }

        /// <summary>git_pull_request_merge_attempted block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_merge_attempted ServicehookWebhookTfs#git_pull_request_merge_attempted}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitPullRequestMergeAttempted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttempted\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted? GitPullRequestMergeAttempted
        {
            get;
            set;
        }

        /// <summary>git_pull_request_updated block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_pull_request_updated ServicehookWebhookTfs#git_pull_request_updated}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitPullRequestUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestUpdated\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestUpdated? GitPullRequestUpdated
        {
            get;
            set;
        }

        /// <summary>git_push block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#git_push ServicehookWebhookTfs#git_push}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitPush", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPush\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPush? GitPush
        {
            get;
            set;
        }

        /// <summary>HTTP headers as key-value pairs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#http_headers ServicehookWebhookTfs#http_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? HttpHeaders
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Resource details to send - all, text, html, markdown or none.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#messages_to_send ServicehookWebhookTfs#messages_to_send}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "messagesToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessagesToSend
        {
            get;
            set;
        }

        /// <summary>repository_created block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_created ServicehookWebhookTfs#repository_created}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryCreated\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryCreated? RepositoryCreated
        {
            get;
            set;
        }

        /// <summary>repository_deleted block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_deleted ServicehookWebhookTfs#repository_deleted}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryDeleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryDeleted\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryDeleted? RepositoryDeleted
        {
            get;
            set;
        }

        /// <summary>repository_forked block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_forked ServicehookWebhookTfs#repository_forked}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryForked", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryForked\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryForked? RepositoryForked
        {
            get;
            set;
        }

        /// <summary>repository_renamed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_renamed ServicehookWebhookTfs#repository_renamed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryRenamed", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamed\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed? RepositoryRenamed
        {
            get;
            set;
        }

        /// <summary>repository_status_changed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#repository_status_changed ServicehookWebhookTfs#repository_status_changed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryStatusChanged", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryStatusChanged\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryStatusChanged? RepositoryStatusChanged
        {
            get;
            set;
        }

        /// <summary>Resource details to send - all, minimal, or none.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#resource_details_to_send ServicehookWebhookTfs#resource_details_to_send}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceDetailsToSend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceDetailsToSend
        {
            get;
            set;
        }

        /// <summary>The resource version for the webhook subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#resource_version ServicehookWebhookTfs#resource_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceVersion
        {
            get;
            set;
        }

        /// <summary>service_connection_created block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#service_connection_created ServicehookWebhookTfs#service_connection_created}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceConnectionCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionCreated\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionCreated? ServiceConnectionCreated
        {
            get;
            set;
        }

        /// <summary>service_connection_updated block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#service_connection_updated ServicehookWebhookTfs#service_connection_updated}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceConnectionUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdated\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated? ServiceConnectionUpdated
        {
            get;
            set;
        }

        /// <summary>tfvc_checkin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#tfvc_checkin ServicehookWebhookTfs#tfvc_checkin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tfvcCheckin", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckin\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin? TfvcCheckin
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#timeouts ServicehookWebhookTfs#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTimeouts\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>work_item_commented block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_commented ServicehookWebhookTfs#work_item_commented}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workItemCommented", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommented\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented? WorkItemCommented
        {
            get;
            set;
        }

        /// <summary>work_item_created block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_created ServicehookWebhookTfs#work_item_created}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workItemCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCreated\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCreated? WorkItemCreated
        {
            get;
            set;
        }

        /// <summary>work_item_deleted block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_deleted ServicehookWebhookTfs#work_item_deleted}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workItemDeleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeleted\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted? WorkItemDeleted
        {
            get;
            set;
        }

        /// <summary>work_item_restored block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_restored ServicehookWebhookTfs#work_item_restored}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workItemRestored", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemRestored\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemRestored? WorkItemRestored
        {
            get;
            set;
        }

        /// <summary>work_item_updated block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_updated ServicehookWebhookTfs#work_item_updated}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workItemUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdated\"}", isOptional: true)]
        public azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated? WorkItemUpdated
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
