using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppTemplateCustomScaleRule), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateCustomScaleRule")]
    public interface IContainerAppTemplateCustomScaleRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#custom_rule_type ContainerApp#custom_rule_type}.</summary>
        [JsiiProperty(name: "customRuleType", typeJson: "{\"primitive\":\"string\"}")]
        string CustomRuleType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#metadata ContainerApp#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#name ContainerApp#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#authentication ContainerApp#authentication}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateCustomScaleRuleAuthentication" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateCustomScaleRuleAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#identity_id ContainerApp#identity_id}
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

        [JsiiTypeProxy(nativeType: typeof(IContainerAppTemplateCustomScaleRule), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateCustomScaleRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppTemplateCustomScaleRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#custom_rule_type ContainerApp#custom_rule_type}.</summary>
            [JsiiProperty(name: "customRuleType", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomRuleType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#metadata ContainerApp#metadata}.</summary>
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#name ContainerApp#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authentication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#authentication ContainerApp#authentication}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateCustomScaleRuleAuthentication" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateCustomScaleRuleAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Authentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ID of the System or User Managed Identity used to execute scale rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#identity_id ContainerApp#identity_id}
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
