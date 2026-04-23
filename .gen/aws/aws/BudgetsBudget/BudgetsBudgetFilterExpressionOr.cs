using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiByValue(fqn: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOr")]
    public class BudgetsBudgetFilterExpressionOr : aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOr
    {
        private object? _and;

        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#and BudgetsBudget#and}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? And
        {
            get => _and;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAnd[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAnd).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _and = value;
            }
        }

        /// <summary>cost_categories block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_categories BudgetsBudget#cost_categories}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrCostCategories\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrCostCategories? CostCategories
        {
            get;
            set;
        }

        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#dimensions BudgetsBudget#dimensions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrDimensions\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrDimensions? Dimensions
        {
            get;
            set;
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#not BudgetsBudget#not}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrNot\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrNot? Not
        {
            get;
            set;
        }

        private object? _or;

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#or BudgetsBudget#or}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Or
        {
            get => _or;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOr[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOr).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _or = value;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrTags\"}", isOptional: true)]
        public aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrTags? Tags
        {
            get;
            set;
        }
    }
}
