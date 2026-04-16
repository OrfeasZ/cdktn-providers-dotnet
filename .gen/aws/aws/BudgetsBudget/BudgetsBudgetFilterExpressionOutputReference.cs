using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiClass(nativeType: typeof(aws.BudgetsBudget.BudgetsBudgetFilterExpressionOutputReference), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BudgetsBudgetFilterExpressionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BudgetsBudgetFilterExpressionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetFilterExpressionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetFilterExpressionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAnd\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnd(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAnd[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAnd).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAnd).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCostCategories", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionCostCategories\"}}]")]
        public virtual void PutCostCategories(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionCostCategories @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionCostCategories)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimensions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionDimensions\"}}]")]
        public virtual void PutDimensions(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionDimensions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionDimensions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNot\"}}]")]
        public virtual void PutNot(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOr", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOr\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOr(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOr[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOr).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOr).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionTags\"}}]")]
        public virtual void PutTags(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionTags)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnd")]
        public virtual void ResetAnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCostCategories")]
        public virtual void ResetCostCategories()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDimensions")]
        public virtual void ResetDimensions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNot")]
        public virtual void ResetNot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOr")]
        public virtual void ResetOr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndList\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndList And
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndList>()!;
        }

        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionCostCategoriesOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionCostCategoriesOutputReference CostCategories
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionCostCategoriesOutputReference>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionDimensionsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionDimensionsOutputReference Dimensions
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionDimensionsOutputReference>()!;
        }

        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOutputReference Not
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOutputReference>()!;
        }

        [JsiiProperty(name: "or", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrList\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrList Or
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionTagsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AndInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoriesInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionCostCategories\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionCostCategories? CostCategoriesInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionCostCategories?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionDimensions\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionDimensions? DimensionsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionDimensions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNot\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNot? NotInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionTags\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionTags? TagsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpression\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpression? InternalValue
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpression?>();
            set => SetInstanceProperty(value);
        }
    }
}
