using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiClass(nativeType: typeof(aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrOutputReference), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BudgetsBudgetFilterExpressionOrOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BudgetsBudgetFilterExpressionOrOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetFilterExpressionOrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetFilterExpressionOrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAnd\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnd(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAnd[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAnd).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAnd).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCostCategories", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrCostCategories\"}}]")]
        public virtual void PutCostCategories(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrCostCategories @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrCostCategories)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimensions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrDimensions\"}}]")]
        public virtual void PutDimensions(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrDimensions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrDimensions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrNot\"}}]")]
        public virtual void PutNot(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrNot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrNot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOr", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOr\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOr(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOr[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOr).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrOr).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrTags\"}}]")]
        public virtual void PutTags(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrTags)}, new object[]{@value});
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

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndList\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndList And
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndList>()!;
        }

        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrCostCategoriesOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrCostCategoriesOutputReference CostCategories
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrCostCategoriesOutputReference>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrDimensionsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrDimensionsOutputReference Dimensions
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrDimensionsOutputReference>()!;
        }

        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrNotOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrNotOutputReference Not
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrNotOutputReference>()!;
        }

        [JsiiProperty(name: "or", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOrList\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrOrList Or
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrOrList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrTagsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AndInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoriesInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrCostCategories\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrCostCategories? CostCategoriesInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrCostCategories?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrDimensions\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrDimensions? DimensionsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrDimensions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrNot\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrNot? NotInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrNot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrTags\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrTags? TagsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOr\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOr cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOr).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
