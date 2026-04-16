using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetFilterExpressionNot), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionNot")]
    public interface IBudgetsBudgetFilterExpressionNot
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#and BudgetsBudget#and}
        /// </remarks>
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? And
        {
            get
            {
                return null;
            }
        }

        /// <summary>cost_categories block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
        /// </remarks>
        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotCostCategories\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotCostCategories? CostCategories
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
        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotDimensions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotDimensions? Dimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#not BudgetsBudget#not}
        /// </remarks>
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotNot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotNot? Not
        {
            get
            {
                return null;
            }
        }

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#or BudgetsBudget#or}
        /// </remarks>
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Or
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
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetFilterExpressionNot), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionNot")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#and BudgetsBudget#and}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? And
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cost_categories block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotCostCategories\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotCostCategories? CostCategories
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotCostCategories?>();
            }

            /// <summary>dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotDimensions\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotDimensions? Dimensions
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotDimensions?>();
            }

            /// <summary>not block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#not BudgetsBudget#not}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotNot\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotNot? Not
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotNot?>();
            }

            /// <summary>or block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#or BudgetsBudget#or}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Or
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotTags\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotTags? Tags
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotTags?>();
            }
        }
    }
}
