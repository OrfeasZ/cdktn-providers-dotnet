using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRules")]
    public class ContainerAppJobEventTriggerConfigScaleRules : azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#custom_rule_type ContainerAppJob#custom_rule_type}.</summary>
        [JsiiProperty(name: "customRuleType", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomRuleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#metadata ContainerAppJob#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#name ContainerAppJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _authentication;

        /// <summary>authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#authentication ContainerAppJob#authentication}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRulesAuthentication" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRulesAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRulesAuthentication[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRulesAuthentication).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authentication = value;
            }
        }

        /// <summary>ID of the System or User Managed Identity used to execute scale rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app_job#identity_id ContainerAppJob#identity_id}
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
