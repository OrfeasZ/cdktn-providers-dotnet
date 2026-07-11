using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetManagementGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupNotification")]
    public class ConsumptionBudgetManagementGroupNotification : azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/consumption_budget_management_group#contact_emails ConsumptionBudgetManagementGroup#contact_emails}.</summary>
        [JsiiProperty(name: "contactEmails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ContactEmails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/consumption_budget_management_group#operator ConsumptionBudgetManagementGroup#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/consumption_budget_management_group#threshold ConsumptionBudgetManagementGroup#threshold}.</summary>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        public double Threshold
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/consumption_budget_management_group#enabled ConsumptionBudgetManagementGroup#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/consumption_budget_management_group#threshold_type ConsumptionBudgetManagementGroup#threshold_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThresholdType
        {
            get;
            set;
        }
    }
}
