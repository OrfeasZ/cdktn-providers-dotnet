using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetFilterExpressionOrOr), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOr")]
    public interface IBudgetsBudgetFilterExpressionOrOr
    {
        /// <summary>cost_categories block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
        /// </remarks>
        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOrCostCategories\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrCostCategories? CostCategories
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
        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOrDimensions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrDimensions? Dimensions
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
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOrTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetFilterExpressionOrOr), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOr")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_categories block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOrCostCategories\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrCostCategories? CostCategories
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrCostCategories?>();
            }

            /// <summary>dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOrDimensions\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrDimensions? Dimensions
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrDimensions?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOrTags\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrTags? Tags
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOrTags?>();
            }
        }
    }
}
