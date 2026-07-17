using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiInterface(nativeType: typeof(IServicehookWebhookTfsWorkItemCommented), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommented")]
    public interface IServicehookWebhookTfsWorkItemCommented
    {
        /// <summary>Include only events for work items under a specific area path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#area_path ServicehookWebhookTfs#area_path}
        /// </remarks>
        [JsiiProperty(name: "areaPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AreaPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for work items with a comment that contains a specific string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#comment_pattern ServicehookWebhookTfs#comment_pattern}
        /// </remarks>
        [JsiiProperty(name: "commentPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommentPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for work items that contain a specific tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#tag ServicehookWebhookTfs#tag}
        /// </remarks>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for work items of a specific type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_type ServicehookWebhookTfs#work_item_type}
        /// </remarks>
        [JsiiProperty(name: "workItemType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkItemType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicehookWebhookTfsWorkItemCommented), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommented")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Include only events for work items under a specific area path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#area_path ServicehookWebhookTfs#area_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "areaPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AreaPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for work items with a comment that contains a specific string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#comment_pattern ServicehookWebhookTfs#comment_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "commentPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommentPattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for work items that contain a specific tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#tag ServicehookWebhookTfs#tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for work items of a specific type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#work_item_type ServicehookWebhookTfs#work_item_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workItemType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkItemType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
