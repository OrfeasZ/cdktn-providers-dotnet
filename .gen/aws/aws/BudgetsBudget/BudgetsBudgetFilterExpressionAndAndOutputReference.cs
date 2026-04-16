using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    [JsiiClass(nativeType: typeof(aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndAndOutputReference), fullyQualifiedName: "aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BudgetsBudgetFilterExpressionAndAndOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BudgetsBudgetFilterExpressionAndAndOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BudgetsBudgetFilterExpressionAndAndOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetFilterExpressionAndAndOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategories", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndCostCategories\"}}]")]
        public virtual void PutCostCategories(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndCostCategories @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndCostCategories)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimensions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndDimensions\"}}]")]
        public virtual void PutDimensions(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndDimensions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndDimensions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndTags\"}}]")]
        public virtual void PutTags(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndTags)}, new object[]{@value});
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

        [JsiiProperty(name: "costCategories", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndCostCategoriesOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndAndCostCategoriesOutputReference CostCategories
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndAndCostCategoriesOutputReference>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndDimensionsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndAndDimensionsOutputReference Dimensions
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndAndDimensionsOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndTagsOutputReference\"}")]
        public virtual aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndAndTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.BudgetsBudget.BudgetsBudgetFilterExpressionAndAndTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoriesInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndCostCategories\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndCostCategories? CostCategoriesInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndCostCategories?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndDimensions\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndDimensions? DimensionsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndDimensions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAndTags\"}", isOptional: true)]
        public virtual aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndTags? TagsInput
        {
            get => GetInstanceProperty<aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAndTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.budgetsBudget.BudgetsBudgetFilterExpressionAndAnd\"}]}}", isOptional: true)]
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
                        case aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAnd cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BudgetsBudget.IBudgetsBudgetFilterExpressionAndAnd).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
