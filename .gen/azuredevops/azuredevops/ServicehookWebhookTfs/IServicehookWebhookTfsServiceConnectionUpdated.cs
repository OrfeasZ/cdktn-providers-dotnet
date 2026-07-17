using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiInterface(nativeType: typeof(IServicehookWebhookTfsServiceConnectionUpdated), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdated")]
    public interface IServicehookWebhookTfsServiceConnectionUpdated
    {
        /// <summary>Include only events for service connections updated in a specific project.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#project_id ServicehookWebhookTfs#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicehookWebhookTfsServiceConnectionUpdated), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdated")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Include only events for service connections updated in a specific project.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#project_id ServicehookWebhookTfs#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
