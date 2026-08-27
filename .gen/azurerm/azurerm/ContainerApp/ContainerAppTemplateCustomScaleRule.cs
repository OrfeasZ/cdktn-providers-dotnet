using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppTemplateCustomScaleRule")]
    public class ContainerAppTemplateCustomScaleRule : azurerm.ContainerApp.IContainerAppTemplateCustomScaleRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app#custom_rule_type ContainerApp#custom_rule_type}.</summary>
        [JsiiProperty(name: "customRuleType", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomRuleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app#metadata ContainerApp#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app#name ContainerApp#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _authentication;

        /// <summary>authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app#authentication ContainerApp#authentication}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateCustomScaleRuleAuthentication" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateCustomScaleRuleAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Authentication
        {
            get => _authentication;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateCustomScaleRuleAuthentication[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateCustomScaleRuleAuthentication).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authentication = value;
            }
        }

        /// <summary>ID of the System or User Managed Identity used to execute scale rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/container_app#identity_id ContainerApp#identity_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityId
        {
            get;
            set;
        }
    }
}
