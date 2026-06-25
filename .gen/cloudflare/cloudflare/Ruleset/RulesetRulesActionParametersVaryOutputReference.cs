using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiClass(nativeType: typeof(cloudflare.Ruleset.RulesetRulesActionParametersVaryOutputReference), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersVaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RulesetRulesActionParametersVaryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RulesetRulesActionParametersVaryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RulesetRulesActionParametersVaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RulesetRulesActionParametersVaryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefault", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryDefault\"}}]")]
        public virtual void PutDefault(cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders" />&gt;</param>
        [JsiiMethod(name: "putHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryHeaders\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutHeaders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHeaders")]
        public virtual void ResetHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "default", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryDefaultOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersVaryDefaultOutputReference Default
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersVaryDefaultOutputReference>()!;
        }

        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryHeadersMap\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersVaryHeadersMap Headers
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersVaryHeadersMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultInput", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryDefault\"}", isOptional: true)]
        public virtual cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault? DefaultInput
        {
            get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders" />&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryHeaders\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? HeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Ruleset.IRulesetRulesActionParametersVary" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVary\"}]}}", isOptional: true)]
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
                        case cloudflare.Ruleset.IRulesetRulesActionParametersVary cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersVary).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
