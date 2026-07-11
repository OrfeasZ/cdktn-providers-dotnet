using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetManagementGroup
{
    [JsiiByValue(fqn: "azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilter")]
    public class ConsumptionBudgetManagementGroupFilter : azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilter
    {
        private object? _dimension;

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/consumption_budget_management_group#dimension ConsumptionBudgetManagementGroup#dimension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dimension
        {
            get => _dimension;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dimension = value;
            }
        }

        private object? _tag;

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/consumption_budget_management_group#tag ConsumptionBudgetManagementGroup#tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tag
        {
            get => _tag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tag = value;
            }
        }
    }
}
