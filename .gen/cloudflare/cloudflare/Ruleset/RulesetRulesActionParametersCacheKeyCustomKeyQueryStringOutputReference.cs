using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiClass(nativeType: typeof(cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude\"}}]")]
        public virtual void PutExclude(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude\"}}]")]
        public virtual void PutInclude(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExclude")]
        public virtual void ResetExclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInclude")]
        public virtual void ResetInclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExcludeOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExcludeOutputReference Exclude
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExcludeOutputReference>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringIncludeOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringIncludeOutputReference Include
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringIncludeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude\"}]}}", isOptional: true)]
        public virtual object? ExcludeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude\"}]}}", isOptional: true)]
        public virtual object? IncludeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryString\"}]}}", isOptional: true)]
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
                        case cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryString cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryString).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
