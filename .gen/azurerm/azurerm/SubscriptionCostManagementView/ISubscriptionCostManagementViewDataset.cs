using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementView
{
    [JsiiInterface(nativeType: typeof(ISubscriptionCostManagementViewDataset), fullyQualifiedName: "azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDataset")]
    public interface ISubscriptionCostManagementViewDataset
    {
        /// <summary>aggregation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/subscription_cost_management_view#aggregation SubscriptionCostManagementView#aggregation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetAggregation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "aggregation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}")]
        object Aggregation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/subscription_cost_management_view#granularity SubscriptionCostManagementView#granularity}.</summary>
        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        string Granularity
        {
            get;
        }

        /// <summary>grouping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/subscription_cost_management_view#grouping SubscriptionCostManagementView#grouping}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetGrouping" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "grouping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Grouping
        {
            get
            {
                return null;
            }
        }

        /// <summary>sorting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/subscription_cost_management_view#sorting SubscriptionCostManagementView#sorting}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetSorting" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sorting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sorting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionCostManagementViewDataset), fullyQualifiedName: "azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDataset")]
        internal sealed class _Proxy : DeputyBase, azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDataset
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aggregation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/subscription_cost_management_view#aggregation SubscriptionCostManagementView#aggregation}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetAggregation" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "aggregation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}")]
            public object Aggregation
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/subscription_cost_management_view#granularity SubscriptionCostManagementView#granularity}.</summary>
            [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
            public string Granularity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>grouping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/subscription_cost_management_view#grouping SubscriptionCostManagementView#grouping}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetGrouping" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grouping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Grouping
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sorting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/subscription_cost_management_view#sorting SubscriptionCostManagementView#sorting}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetSorting" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sorting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Sorting
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
