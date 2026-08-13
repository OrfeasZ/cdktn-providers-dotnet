using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiInterface(nativeType: typeof(IContainerAppJobEventTriggerConfigScaleRules), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRules")]
    public interface IContainerAppJobEventTriggerConfigScaleRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#custom_rule_type ContainerAppJob#custom_rule_type}.</summary>
        [JsiiProperty(name: "customRuleType", typeJson: "{\"primitive\":\"string\"}")]
        string CustomRuleType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#metadata ContainerAppJob#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#name ContainerAppJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#authentication ContainerAppJob#authentication}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRulesAuthentication" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRulesAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Authentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the System or User Managed Identity used to execute scale rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#identity_id ContainerAppJob#identity_id}
        /// </remarks>
        [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppJobEventTriggerConfigScaleRules), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#custom_rule_type ContainerAppJob#custom_rule_type}.</summary>
            [JsiiProperty(name: "customRuleType", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomRuleType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#metadata ContainerAppJob#metadata}.</summary>
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#name ContainerAppJob#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authentication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#authentication ContainerAppJob#authentication}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRulesAuthentication" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRulesAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Authentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ID of the System or User Managed Identity used to execute scale rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app_job#identity_id ContainerAppJob#identity_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
