using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicationRecoveryPlan
{
    [JsiiClass(nativeType: typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupOutputReference), fullyQualifiedName: "azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction" />)[]</param>
        [JsiiMethod(name: "putPostAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPostAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction" />)[]</param>
        [JsiiMethod(name: "putPreAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPreAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPostAction")]
        public virtual void ResetPostAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreAction")]
        public virtual void ResetPreAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "postAction", typeJson: "{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostActionList\"}")]
        public virtual azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostActionList PostAction
        {
            get => GetInstanceProperty<azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostActionList>()!;
        }

        [JsiiProperty(name: "preAction", typeJson: "{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreActionList\"}")]
        public virtual azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreActionList PreAction
        {
            get => GetInstanceProperty<azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreActionList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PostActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PreActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup\"}", isOptional: true)]
        public virtual azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup? InternalValue
        {
            get => GetInstanceProperty<azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup?>();
            set => SetInstanceProperty(value);
        }
    }
}
