using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetSubscription
{
    [JsiiByValue(fqn: "azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilter")]
    public class ConsumptionBudgetSubscriptionFilter : azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilter
    {
        private object? _dimension;

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/consumption_budget_subscription#dimension ConsumptionBudgetSubscription#dimension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterDimension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterDimension[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterDimension).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dimension = value;
            }
        }

        private object? _tag;

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/consumption_budget_subscription#tag ConsumptionBudgetSubscription#tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterTag" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tag = value;
            }
        }
    }
}
