using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRunbook
{
    [JsiiByValue(fqn: "azurerm.automationRunbook.AutomationRunbookDraft")]
    public class AutomationRunbookDraft : azurerm.AutomationRunbook.IAutomationRunbookDraft
    {
        /// <summary>content_link block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_runbook#content_link AutomationRunbook#content_link}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentLink", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftContentLink\"}", isOptional: true)]
        public azurerm.AutomationRunbook.IAutomationRunbookDraftContentLink? ContentLink
        {
            get;
            set;
        }

        private object? _editModeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_runbook#edit_mode_enabled AutomationRunbook#edit_mode_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "editModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EditModeEnabled
        {
            get => _editModeEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _editModeEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_runbook#output_types AutomationRunbook#output_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OutputTypes
        {
            get;
            set;
        }

        private object? _parameters;

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/automation_runbook#parameters AutomationRunbook#parameters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationRunbook.IAutomationRunbookDraftParameters" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameters
        {
            get => _parameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.AutomationRunbook.IAutomationRunbookDraftParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.AutomationRunbook.IAutomationRunbookDraftParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parameters = value;
            }
        }
    }
}
