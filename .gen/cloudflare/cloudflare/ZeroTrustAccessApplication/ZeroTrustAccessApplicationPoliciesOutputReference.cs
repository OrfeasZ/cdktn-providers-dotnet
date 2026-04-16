using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessApplicationPoliciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessApplicationPoliciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessApplicationPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessApplicationPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRules\"}}]")]
        public virtual void PutConnectionRules(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRules)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExclude\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExclude(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExclude[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExclude).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExclude).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesInclude\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInclude(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesInclude[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesInclude).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesInclude).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequire", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequire\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequire(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequire[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequire).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequire).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionRules")]
        public virtual void ResetConnectionRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDecision")]
        public virtual void ResetDecision()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExclude")]
        public virtual void ResetExclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInclude")]
        public virtual void ResetInclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrecedence")]
        public virtual void ResetPrecedence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequire")]
        public virtual void ResetRequire()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectionRules", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference ConnectionRules
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference>()!;
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeList\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeList Exclude
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeList>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeList\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeList Include
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeList>()!;
        }

        [JsiiProperty(name: "require", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireList\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireList Require
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRules\"}]}}", isOptional: true)]
        public virtual object? ConnectionRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "decisionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DecisionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExcludeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesInclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IncludeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "precedenceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PrecedenceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequire\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequireInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "decision", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Decision
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Precedence
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPolicies\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPolicies cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPolicies).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
