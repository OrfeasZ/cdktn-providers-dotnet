using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiInterface(nativeType: typeof(IServicehookWebhookTfsWorkItemUpdated), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdated")]
    public interface IServicehookWebhookTfsWorkItemUpdated
    {
        /// <summary>Include only events for work items under a specific area path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#area_path ServicehookWebhookTfs#area_path}
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

        /// <summary>Include only events for work items with a change in a specific field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#changed_fields ServicehookWebhookTfs#changed_fields}
        /// </remarks>
        [JsiiProperty(name: "changedFields", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ChangedFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for work items with one or more links added or removed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#links_changed ServicehookWebhookTfs#links_changed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "linksChanged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LinksChanged
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for work items that contain a specific tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#tag ServicehookWebhookTfs#tag}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#work_item_type ServicehookWebhookTfs#work_item_type}
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

        [JsiiTypeProxy(nativeType: typeof(IServicehookWebhookTfsWorkItemUpdated), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdated")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Include only events for work items under a specific area path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#area_path ServicehookWebhookTfs#area_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "areaPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AreaPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for work items with a change in a specific field.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#changed_fields ServicehookWebhookTfs#changed_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "changedFields", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ChangedFields
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for work items with one or more links added or removed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#links_changed ServicehookWebhookTfs#links_changed}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linksChanged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LinksChanged
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Include only events for work items that contain a specific tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#tag ServicehookWebhookTfs#tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for work items of a specific type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#work_item_type ServicehookWebhookTfs#work_item_type}
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
