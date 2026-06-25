using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    [JsiiClass(nativeType: typeof(cloudflare.FlagshipFlag.FlagshipFlagRulesConditionsClausesOutputReference), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagRulesConditionsClausesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FlagshipFlagRulesConditionsClausesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public FlagshipFlagRulesConditionsClausesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected FlagshipFlagRulesConditionsClausesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FlagshipFlagRulesConditionsClausesOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses" />)[]</param>
        [JsiiMethod(name: "putClauses", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditionsClauses\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClauses(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttribute")]
        public virtual void ResetAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClauses")]
        public virtual void ResetClauses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogicalOperator")]
        public virtual void ResetLogicalOperator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperator")]
        public virtual void ResetOperator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValue")]
        public virtual void ResetValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clauses", typeJson: "{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditionsClausesList\"}")]
        public virtual cloudflare.FlagshipFlag.FlagshipFlagRulesConditionsClausesList Clauses
        {
            get => GetInstanceProperty<cloudflare.FlagshipFlag.FlagshipFlagRulesConditionsClausesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clausesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditionsClauses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClausesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logicalOperatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogicalOperatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogicalOperator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditionsClauses\"}]}}", isOptional: true)]
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
                        case cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
