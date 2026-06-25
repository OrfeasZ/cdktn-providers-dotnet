using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    [JsiiClass(nativeType: typeof(cloudflare.FlagshipFlag.FlagshipFlagRulesOutputReference), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FlagshipFlagRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public FlagshipFlagRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected FlagshipFlagRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FlagshipFlagRulesOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions" />)[]</param>
        [JsiiMethod(name: "putConditions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConditions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesRollout\"}}]")]
        public virtual void PutRollout(cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRollout")]
        public virtual void ResetRollout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditionsList\"}")]
        public virtual cloudflare.FlagshipFlag.FlagshipFlagRulesConditionsList Conditions
        {
            get => GetInstanceProperty<cloudflare.FlagshipFlag.FlagshipFlagRulesConditionsList>()!;
        }

        [JsiiProperty(name: "rollout", typeJson: "{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesRolloutOutputReference\"}")]
        public virtual cloudflare.FlagshipFlag.FlagshipFlagRulesRolloutOutputReference Rollout
        {
            get => GetInstanceProperty<cloudflare.FlagshipFlag.FlagshipFlagRulesRolloutOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConditionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rolloutInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesRollout\"}]}}", isOptional: true)]
        public virtual object? RolloutInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serveVariationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServeVariationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serveVariation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServeVariation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.FlagshipFlag.IFlagshipFlagRules" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRules\"}]}}", isOptional: true)]
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
                        case cloudflare.FlagshipFlag.IFlagshipFlagRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
