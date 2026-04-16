using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiByValue(fqn: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAnd")]
    public class BudgetsBudgetFilterExpressionOrAnd : aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAnd
    {
        /// <summary>cost_categories block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndCostCategories\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndCostCategories? CostCategories
        {
            get;
            set;
        }

        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndDimensions\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndDimensions? Dimensions
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndTags\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndTags? Tags
        {
            get;
            set;
        }
    }
}
