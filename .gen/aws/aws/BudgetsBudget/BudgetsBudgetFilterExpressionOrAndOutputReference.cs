using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiClass(nativeType: typeof(aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndOutputReference), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BudgetsBudgetFilterExpressionOrAndOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BudgetsBudgetFilterExpressionOrAndOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BudgetsBudgetFilterExpressionOrAndOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetFilterExpressionOrAndOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategories", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndCostCategories\"}}]")]
        public virtual void PutCostCategories(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndCostCategories @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndCostCategories)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimensions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndDimensions\"}}]")]
        public virtual void PutDimensions(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndDimensions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndDimensions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndTags\"}}]")]
        public virtual void PutTags(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndTags)}, new object[]{@value});
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

        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndCostCategoriesOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndCostCategoriesOutputReference CostCategories
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndCostCategoriesOutputReference>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndDimensionsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndDimensionsOutputReference Dimensions
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndDimensionsOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndTagsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionOrAndTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoriesInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndCostCategories\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndCostCategories? CostCategoriesInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndCostCategories?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndDimensions\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndDimensions? DimensionsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndDimensions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAndTags\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndTags? TagsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAndTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionOrAnd\"}]}}", isOptional: true)]
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
                        case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAnd cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionOrAnd).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
