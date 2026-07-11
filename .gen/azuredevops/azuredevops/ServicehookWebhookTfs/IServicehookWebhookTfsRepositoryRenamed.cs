using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiInterface(nativeType: typeof(IServicehookWebhookTfsRepositoryRenamed), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamed")]
    public interface IServicehookWebhookTfsRepositoryRenamed
    {
        /// <summary>Include only events for repositories with a specific repository ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#repository_id ServicehookWebhookTfs#repository_id}
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

        [JsiiTypeProxy(nativeType: typeof(IServicehookWebhookTfsRepositoryRenamed), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamed")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Include only events for repositories with a specific repository ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#repository_id ServicehookWebhookTfs#repository_id}
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
