using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    [JsiiInterface(nativeType: typeof(IAutomationSoftwareUpdateConfigurationTarget), fullyQualifiedName: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTarget")]
    public interface IAutomationSoftwareUpdateConfigurationTarget
    {
        /// <summary>azure_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_software_update_configuration#azure_query AutomationSoftwareUpdateConfiguration#azure_query}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "azureQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetAzureQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureQuery
        {
            get
            {
                return null;
            }
        }

        /// <summary>non_azure_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_software_update_configuration#non_azure_query AutomationSoftwareUpdateConfiguration#non_azure_query}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "nonAzureQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NonAzureQuery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationSoftwareUpdateConfigurationTarget), fullyQualifiedName: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTarget")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_query block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_software_update_configuration#azure_query AutomationSoftwareUpdateConfiguration#azure_query}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetAzureQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AzureQuery
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>non_azure_query block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_software_update_configuration#non_azure_query AutomationSoftwareUpdateConfiguration#non_azure_query}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nonAzureQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NonAzureQuery
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
