using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    [JsiiByValue(fqn: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTarget")]
    public class AutomationSoftwareUpdateConfigurationTarget : azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget
    {
        private object? _azureQuery;

        /// <summary>azure_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_software_update_configuration#azure_query AutomationSoftwareUpdateConfiguration#azure_query}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetAzureQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AzureQuery
        {
            get => _azureQuery;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _azureQuery = value;
            }
        }

        private object? _nonAzureQuery;

        /// <summary>non_azure_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_software_update_configuration#non_azure_query AutomationSoftwareUpdateConfiguration#non_azure_query}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nonAzureQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NonAzureQuery
        {
            get => _nonAzureQuery;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nonAzureQuery = value;
            }
        }
    }
}
