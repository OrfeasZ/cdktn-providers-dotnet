using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetFilterExpressionAndNot), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionAndNot")]
    public interface IBudgetsBudgetFilterExpressionAndNot
    {
        /// <summary>cost_categories block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
        /// </remarks>
        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndNotCostCategories\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotCostCategories? CostCategories
        {
            get
            {
                return null;
            }
        }

        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
        /// </remarks>
        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndNotDimensions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotDimensions? Dimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndNotTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetFilterExpressionAndNot), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionAndNot")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_categories block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndNotCostCategories\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotCostCategories? CostCategories
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotCostCategories?>();
            }

            /// <summary>dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndNotDimensions\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotDimensions? Dimensions
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotDimensions?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndNotTags\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotTags? Tags
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndNotTags?>();
            }
        }
    }
}
