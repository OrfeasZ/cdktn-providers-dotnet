using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetFilterExpressionOr), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOr")]
    public interface IBudgetsBudgetFilterExpressionOr
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#and BudgetsBudget#and}
        /// </remarks>
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
        /// </remarks>
        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrCostCategories\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrCostCategories? CostCategories
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
        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrDimensions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrDimensions? Dimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#not BudgetsBudget#not}
        /// </remarks>
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrNot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrNot? Not
        {
            get
            {
                return null;
            }
        }

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#or BudgetsBudget#or}
        /// </remarks>
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetFilterExpressionOr), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOr")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#and BudgetsBudget#and}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? And
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cost_categories block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrCostCategories\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrCostCategories? CostCategories
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrCostCategories?>();
            }

            /// <summary>dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrDimensions\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrDimensions? Dimensions
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrDimensions?>();
            }

            /// <summary>not block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#not BudgetsBudget#not}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrNot\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrNot? Not
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrNot?>();
            }

            /// <summary>or block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#or BudgetsBudget#or}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Or
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrTags\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrTags? Tags
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrTags?>();
            }
        }
    }
}
