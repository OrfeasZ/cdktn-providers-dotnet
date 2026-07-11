using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicationRecoveryPlan
{
    [JsiiClass(nativeType: typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupOutputReference), fullyQualifiedName: "azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostAction" />)[]</param>
        [JsiiMethod(name: "putPostAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPostAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreAction" />)[]</param>
        [JsiiMethod(name: "putPreAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPreAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiProperty(name: "postAction", typeJson: "{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostActionList\"}")]
        public virtual azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostActionList PostAction
        {
            get => GetInstanceProperty<azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostActionList>()!;
        }

        [JsiiProperty(name: "preAction", typeJson: "{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreActionList\"}")]
        public virtual azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreActionList PreAction
        {
            get => GetInstanceProperty<azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreActionList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostAction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPostAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PostActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreAction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroupPreAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PreActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroup\"}", isOptional: true)]
        public virtual azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroup? InternalValue
        {
            get => GetInstanceProperty<azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroup?>();
            set => SetInstanceProperty(value);
        }
    }
}
