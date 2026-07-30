using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetManagementGroup
{
    [JsiiInterface(nativeType: typeof(IConsumptionBudgetManagementGroupFilter), fullyQualifiedName: "azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilter")]
    public interface IConsumptionBudgetManagementGroupFilter
    {
        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/consumption_budget_management_group#dimension ConsumptionBudgetManagementGroup#dimension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/consumption_budget_management_group#tag ConsumptionBudgetManagementGroup#tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tag
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConsumptionBudgetManagementGroupFilter), fullyQualifiedName: "azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/consumption_budget_management_group#dimension ConsumptionBudgetManagementGroup#dimension}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Dimension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/consumption_budget_management_group#tag ConsumptionBudgetManagementGroup#tag}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tag
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
