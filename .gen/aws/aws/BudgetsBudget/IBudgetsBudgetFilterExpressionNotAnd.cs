using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetFilterExpressionNotAnd), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAnd")]
    public interface IBudgetsBudgetFilterExpressionNotAnd
    {
        /// <summary>cost_categories block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
        /// </remarks>
        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAndCostCategories\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndCostCategories? CostCategories
        {
            get
            {
                return null;
            }
        }

        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
        /// </remarks>
        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAndDimensions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndDimensions? Dimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAndTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetFilterExpressionNotAnd), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAnd")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAnd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_categories block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAndCostCategories\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndCostCategories? CostCategories
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndCostCategories?>();
            }

            /// <summary>dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAndDimensions\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndDimensions? Dimensions
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndDimensions?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAndTags\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndTags? Tags
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndTags?>();
            }
        }
    }
}
