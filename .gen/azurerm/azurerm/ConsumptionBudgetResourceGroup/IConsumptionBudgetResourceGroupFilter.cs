using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetResourceGroup
{
    [JsiiInterface(nativeType: typeof(IConsumptionBudgetResourceGroupFilter), fullyQualifiedName: "azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilter")]
    public interface IConsumptionBudgetResourceGroupFilter
    {
        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/consumption_budget_resource_group#dimension ConsumptionBudgetResourceGroup#dimension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilterDimension" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/consumption_budget_resource_group#tag ConsumptionBudgetResourceGroup#tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilterTag" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tag
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConsumptionBudgetResourceGroupFilter), fullyQualifiedName: "azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/consumption_budget_resource_group#dimension ConsumptionBudgetResourceGroup#dimension}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilterDimension" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Dimension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/consumption_budget_resource_group#tag ConsumptionBudgetResourceGroup#tag}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilterTag" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tag
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
