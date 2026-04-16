using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiClass(nativeType: typeof(cloudflare.Ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlOutputReference), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class RulesetRulesActionParametersEdgeTtlStatusCodeTtlOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public RulesetRulesActionParametersEdgeTtlStatusCodeTtlOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected RulesetRulesActionParametersEdgeTtlStatusCodeTtlOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RulesetRulesActionParametersEdgeTtlStatusCodeTtlOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStatusCodeRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange\"}}]")]
        public virtual void PutStatusCodeRange(cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStatusCode")]
        public virtual void ResetStatusCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatusCodeRange")]
        public virtual void ResetStatusCodeRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "statusCodeRange", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRangeOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRangeOutputReference StatusCodeRange
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusCodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StatusCodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusCodeRangeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange\"}]}}", isOptional: true)]
        public virtual object? StatusCodeRangeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StatusCode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Value
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtl\"}]}}", isOptional: true)]
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
                        case cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtl cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtl).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
