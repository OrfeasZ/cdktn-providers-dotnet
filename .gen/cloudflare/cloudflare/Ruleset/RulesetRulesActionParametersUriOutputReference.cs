using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiClass(nativeType: typeof(cloudflare.Ruleset.RulesetRulesActionParametersUriOutputReference), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersUriOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RulesetRulesActionParametersUriOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RulesetRulesActionParametersUriOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RulesetRulesActionParametersUriOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RulesetRulesActionParametersUriOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriPath\"}}]")]
        public virtual void PutPath(cloudflare.Ruleset.IRulesetRulesActionParametersUriPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersUriPath)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQuery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriQuery\"}}]")]
        public virtual void PutQuery(cloudflare.Ruleset.IRulesetRulesActionParametersUriQuery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersUriQuery)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuery")]
        public virtual void ResetQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriPathOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersUriPathOutputReference Path
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersUriPathOutputReference>()!;
        }

        [JsiiProperty(name: "query", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriQueryOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersUriQueryOutputReference Query
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersUriQueryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriPath\"}]}}", isOptional: true)]
        public virtual object? PathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriQuery\"}]}}", isOptional: true)]
        public virtual object? QueryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUri\"}]}}", isOptional: true)]
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
                        case cloudflare.Ruleset.IRulesetRulesActionParametersUri cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersUri).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
