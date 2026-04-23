using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetConfig), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetConfig")]
    public interface IBudgetsBudgetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#budget_type BudgetsBudget#budget_type}.</summary>
        [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}")]
        string BudgetType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#time_unit BudgetsBudget#time_unit}.</summary>
        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        string TimeUnit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#account_id BudgetsBudget#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_adjust_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#auto_adjust_data BudgetsBudget#auto_adjust_data}
        /// </remarks>
        [JsiiProperty(name: "autoAdjustData", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetAutoAdjustData? AutoAdjustData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#billing_view_arn BudgetsBudget#billing_view_arn}.</summary>
        [JsiiProperty(name: "billingViewArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingViewArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>cost_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_filter BudgetsBudget#cost_filter}
        /// </remarks>
        [JsiiProperty(name: "costFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetCostFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CostFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>cost_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_types BudgetsBudget#cost_types}
        /// </remarks>
        [JsiiProperty(name: "costTypes", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetCostTypes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetCostTypes? CostTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#filter_expression BudgetsBudget#filter_expression}
        /// </remarks>
        [JsiiProperty(name: "filterExpression", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpression\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BudgetsBudget.IBudgetsBudgetFilterExpression? FilterExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#id BudgetsBudget#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#limit_amount BudgetsBudget#limit_amount}.</summary>
        [JsiiProperty(name: "limitAmount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LimitAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#limit_unit BudgetsBudget#limit_unit}.</summary>
        [JsiiProperty(name: "limitUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LimitUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#metrics BudgetsBudget#metrics}.</summary>
        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Metrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#name BudgetsBudget#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#name_prefix BudgetsBudget#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>notification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#notification BudgetsBudget#notification}
        /// </remarks>
        [JsiiProperty(name: "notification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetNotification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Notification
        {
            get
            {
                return null;
            }
        }

        /// <summary>planned_limit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#planned_limit BudgetsBudget#planned_limit}
        /// </remarks>
        [JsiiProperty(name: "plannedLimit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetPlannedLimit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PlannedLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags_all BudgetsBudget#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#time_period_end BudgetsBudget#time_period_end}.</summary>
        [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimePeriodEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#time_period_start BudgetsBudget#time_period_start}.</summary>
        [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimePeriodStart
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetConfig), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BudgetsBudget.IBudgetsBudgetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#budget_type BudgetsBudget#budget_type}.</summary>
            [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}")]
            public string BudgetType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#time_unit BudgetsBudget#time_unit}.</summary>
            [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#account_id BudgetsBudget#account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>auto_adjust_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#auto_adjust_data BudgetsBudget#auto_adjust_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoAdjustData", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetAutoAdjustData\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetAutoAdjustData? AutoAdjustData
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetAutoAdjustData?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#billing_view_arn BudgetsBudget#billing_view_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "billingViewArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingViewArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cost_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_filter BudgetsBudget#cost_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetCostFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CostFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cost_types block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#cost_types BudgetsBudget#cost_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costTypes", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetCostTypes\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetCostTypes? CostTypes
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetCostTypes?>();
            }

            /// <summary>filter_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#filter_expression BudgetsBudget#filter_expression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterExpression", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpression\"}", isOptional: true)]
            public aws.BudgetsBudget.IBudgetsBudgetFilterExpression? FilterExpression
            {
                get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpression?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#id BudgetsBudget#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#limit_amount BudgetsBudget#limit_amount}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "limitAmount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LimitAmount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#limit_unit BudgetsBudget#limit_unit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "limitUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LimitUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#metrics BudgetsBudget#metrics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Metrics
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#name BudgetsBudget#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#name_prefix BudgetsBudget#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>notification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#notification BudgetsBudget#notification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetNotification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Notification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>planned_limit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#planned_limit BudgetsBudget#planned_limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plannedLimit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetPlannedLimit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PlannedLimit
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags BudgetsBudget#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#tags_all BudgetsBudget#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#time_period_end BudgetsBudget#time_period_end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimePeriodEnd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/budgets_budget#time_period_start BudgetsBudget#time_period_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimePeriodStart
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
