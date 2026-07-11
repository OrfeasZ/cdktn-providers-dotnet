using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiInterface(nativeType: typeof(IServicehookWebhookTfsBuildCompleted), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted")]
    public interface IServicehookWebhookTfsBuildCompleted
    {
        /// <summary>Include only events for completed builds that have a specific completion status.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#build_status ServicehookWebhookTfs#build_status}
        /// </remarks>
        [JsiiProperty(name: "buildStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuildStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include only events for completed builds for a specific pipeline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#definition_name ServicehookWebhookTfs#definition_name}
        /// </remarks>
        [JsiiProperty(name: "definitionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefinitionName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicehookWebhookTfsBuildCompleted), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Include only events for completed builds that have a specific completion status.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#build_status ServicehookWebhookTfs#build_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include only events for completed builds for a specific pipeline.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/servicehook_webhook_tfs#definition_name ServicehookWebhookTfs#definition_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "definitionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefinitionName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
