using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CdnFrontdoorBatchRuleSetRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CdnFrontdoorBatchRuleSetRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CdnFrontdoorBatchRuleSetRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorBatchRuleSetRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActions\"}}]")]
        public virtual void PutActions(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConditions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditions\"}}]")]
        public virtual void PutConditions(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBehaviourOnMatch")]
        public virtual void ResetBehaviourOnMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConditions")]
        public virtual void ResetConditions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsOutputReference Actions
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsOutputReference>()!;
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsOutputReference Conditions
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionsInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActions\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActions? ActionsInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "behaviourOnMatchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BehaviourOnMatchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionsInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditions\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditions? ConditionsInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OrderInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "behaviourOnMatch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BehaviourOnMatch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRule" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRule\"}]}}", isOptional: true)]
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
                        case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
