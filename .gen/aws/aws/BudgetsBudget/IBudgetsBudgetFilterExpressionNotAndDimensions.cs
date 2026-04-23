using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetFilterExpressionNotAndDimensions), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAndDimensions")]
    public interface IBudgetsBudgetFilterExpressionNotAndDimensions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#key BudgetsBudget#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#values BudgetsBudget#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#match_options BudgetsBudget#match_options}.</summary>
        [JsiiProperty(name: "matchOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MatchOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetFilterExpressionNotAndDimensions), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionNotAndDimensions")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotAndDimensions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#key BudgetsBudget#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#values BudgetsBudget#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#match_options BudgetsBudget#match_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MatchOptions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
