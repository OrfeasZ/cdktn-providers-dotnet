using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiClass(nativeType: typeof(aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOrOutputReference), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BudgetsBudgetFilterExpressionNotOrOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BudgetsBudgetFilterExpressionNotOrOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BudgetsBudgetFilterExpressionNotOrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetFilterExpressionNotOrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategories", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrCostCategories\"}}]")]
        public virtual void PutCostCategories(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrCostCategories @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrCostCategories)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimensions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrDimensions\"}}]")]
        public virtual void PutDimensions(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrDimensions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrDimensions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrTags\"}}]")]
        public virtual void PutTags(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrTags)}, new object[]{@value});
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

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrCostCategoriesOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOrCostCategoriesOutputReference CostCategories
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOrCostCategoriesOutputReference>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrDimensionsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOrDimensionsOutputReference Dimensions
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOrDimensionsOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrTagsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOrTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionNotOrTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoriesInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrCostCategories\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrCostCategories? CostCategoriesInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrCostCategories?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrDimensions\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrDimensions? DimensionsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrDimensions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOrTags\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrTags? TagsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOrTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionNotOr\"}]}}", isOptional: true)]
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
                        case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOr cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionNotOr).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
