using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetManagementGroup
{
    [JsiiClass(nativeType: typeof(azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterOutputReference), fullyQualifiedName: "azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConsumptionBudgetManagementGroupFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConsumptionBudgetManagementGroupFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConsumptionBudgetManagementGroupFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConsumptionBudgetManagementGroupFilterOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension" />)[]</param>
        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterDimension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDimension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag" />)[]</param>
        [JsiiMethod(name: "putTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDimension")]
        public virtual void ResetDimension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTag")]
        public virtual void ResetTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterDimensionList\"}")]
        public virtual azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterDimensionList Dimension
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterDimensionList>()!;
        }

        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterTagList\"}")]
        public virtual azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterTagList Tag
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterTagList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterDimension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DimensionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilterTag" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilter\"}", isOptional: true)]
        public virtual azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilter? InternalValue
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetManagementGroup.IConsumptionBudgetManagementGroupFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
