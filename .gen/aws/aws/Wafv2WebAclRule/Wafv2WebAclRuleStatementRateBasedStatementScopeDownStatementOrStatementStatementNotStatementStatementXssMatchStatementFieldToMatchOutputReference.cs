using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArguments" />)[]</param>
        [JsiiMethod(name: "putAllQueryArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllQueryArguments(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArguments[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArguments).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArguments).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBody" />)[]</param>
        [JsiiMethod(name: "putBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBody(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBody[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBody).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBody).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookies" />)[]</param>
        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookies\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCookies(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookies[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookies).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookies).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder" />)[]</param>
        [JsiiMethod(name: "putHeaderOrder", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHeaderOrder(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaders" />)[]</param>
        [JsiiMethod(name: "putHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaders\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHeaders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaders[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaders).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaders).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3Fingerprint" />)[]</param>
        [JsiiMethod(name: "putJa3Fingerprint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3Fingerprint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJa3Fingerprint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3Fingerprint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3Fingerprint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3Fingerprint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4Fingerprint" />)[]</param>
        [JsiiMethod(name: "putJa4Fingerprint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4Fingerprint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJa4Fingerprint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4Fingerprint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4Fingerprint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4Fingerprint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBody" />)[]</param>
        [JsiiMethod(name: "putJsonBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBody\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJsonBody(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBody[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBody).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBody).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod" />)[]</param>
        [JsiiMethod(name: "putMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMethod(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryString" />)[]</param>
        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeader" />)[]</param>
        [JsiiMethod(name: "putSingleHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSingleHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument" />)[]</param>
        [JsiiMethod(name: "putSingleQueryArgument", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSingleQueryArgument(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragment" />)[]</param>
        [JsiiMethod(name: "putUriFragment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUriFragment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPath" />)[]</param>
        [JsiiMethod(name: "putUriPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUriPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllQueryArguments")]
        public virtual void ResetAllQueryArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBody")]
        public virtual void ResetBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCookies")]
        public virtual void ResetCookies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeaderOrder")]
        public virtual void ResetHeaderOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeaders")]
        public virtual void ResetHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJa3Fingerprint")]
        public virtual void ResetJa3Fingerprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJa4Fingerprint")]
        public virtual void ResetJa4Fingerprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJsonBody")]
        public virtual void ResetJsonBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMethod")]
        public virtual void ResetMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryString")]
        public virtual void ResetQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSingleHeader")]
        public virtual void ResetSingleHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSingleQueryArgument")]
        public virtual void ResetSingleQueryArgument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUriFragment")]
        public virtual void ResetUriFragment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUriPath")]
        public virtual void ResetUriPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArgumentsList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArgumentsList AllQueryArguments
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArgumentsList>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBodyList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBodyList Body
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBodyList>()!;
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookiesList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookiesList Cookies
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookiesList>()!;
        }

        [JsiiProperty(name: "headerOrder", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrderList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrderList HeaderOrder
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrderList>()!;
        }

        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeadersList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeadersList Headers
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeadersList>()!;
        }

        [JsiiProperty(name: "ja3Fingerprint", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3FingerprintList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3FingerprintList Ja3Fingerprint
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3FingerprintList>()!;
        }

        [JsiiProperty(name: "ja4Fingerprint", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4FingerprintList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4FingerprintList Ja4Fingerprint
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4FingerprintList>()!;
        }

        [JsiiProperty(name: "jsonBody", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBodyList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBodyList JsonBody
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBodyList>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodList Method
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodList>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryStringList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryStringList QueryString
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryStringList>()!;
        }

        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeaderList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeaderList SingleHeader
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeaderList>()!;
        }

        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgumentList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgumentList SingleQueryArgument
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgumentList>()!;
        }

        [JsiiProperty(name: "uriFragment", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragmentList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragmentList UriFragment
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragmentList>()!;
        }

        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPathList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPathList UriPath
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPathList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArguments" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArgumentsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllQueryArgumentsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBody" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BodyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CookiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerOrderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaderOrder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HeaderOrderInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaders" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3Fingerprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ja3FingerprintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa3Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ja3FingerprintInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4Fingerprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ja4FingerprintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJa4Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ja4FingerprintInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBody" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jsonBodyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchJsonBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JsonBodyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryString" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SingleHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgumentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SingleQueryArgumentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriFragmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriFragment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UriFragmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPath" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UriPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch\"}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
