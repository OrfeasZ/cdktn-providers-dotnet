using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiByValue(fqn: "aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOr")]
    public class BudgetsBudgetFilterExpressionNotOr : aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOr
    {
        /// <summary>cost_categories block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrCostCategories\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrCostCategories? CostCategories
        {
            get;
            set;
        }

        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrDimensions\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrDimensions? Dimensions
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrTags\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrTags? Tags
        {
            get;
            set;
        }
    }
}
