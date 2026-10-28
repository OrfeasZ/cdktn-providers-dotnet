using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments" />)[]</param>
        [JsiiMethod(name: "putAllQueryArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllQueryArguments(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody" />)[]</param>
        [JsiiMethod(name: "putBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBody(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookies" />)[]</param>
        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookies\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCookies(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookies[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookies).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookies).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder" />)[]</param>
        [JsiiMethod(name: "putHeaderOrder", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHeaderOrder(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaders" />)[]</param>
        [JsiiMethod(name: "putHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaders\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHeaders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaders[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaders).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaders).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint" />)[]</param>
        [JsiiMethod(name: "putJa3Fingerprint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJa3Fingerprint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint" />)[]</param>
        [JsiiMethod(name: "putJa4Fingerprint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJa4Fingerprint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBody" />)[]</param>
        [JsiiMethod(name: "putJsonBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBody\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJsonBody(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBody[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBody).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBody).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod" />)[]</param>
        [JsiiMethod(name: "putMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMethod(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString" />)[]</param>
        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader" />)[]</param>
        [JsiiMethod(name: "putSingleHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSingleHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument" />)[]</param>
        [JsiiMethod(name: "putSingleQueryArgument", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSingleQueryArgument(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragment" />)[]</param>
        [JsiiMethod(name: "putUriFragment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUriFragment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath" />)[]</param>
        [JsiiMethod(name: "putUriPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUriPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArgumentsList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArgumentsList AllQueryArguments
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArgumentsList>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBodyList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBodyList Body
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBodyList>()!;
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookiesList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookiesList Cookies
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookiesList>()!;
        }

        [JsiiProperty(name: "headerOrder", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrderList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrderList HeaderOrder
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrderList>()!;
        }

        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeadersList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeadersList Headers
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeadersList>()!;
        }

        [JsiiProperty(name: "ja3Fingerprint", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3FingerprintList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3FingerprintList Ja3Fingerprint
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3FingerprintList>()!;
        }

        [JsiiProperty(name: "ja4Fingerprint", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4FingerprintList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4FingerprintList Ja4Fingerprint
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4FingerprintList>()!;
        }

        [JsiiProperty(name: "jsonBody", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBodyList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBodyList JsonBody
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBodyList>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethodList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethodList Method
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethodList>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryStringList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryStringList QueryString
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryStringList>()!;
        }

        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeaderList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeaderList SingleHeader
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeaderList>()!;
        }

        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgumentList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgumentList SingleQueryArgument
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgumentList>()!;
        }

        [JsiiProperty(name: "uriFragment", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragmentList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragmentList UriFragment
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragmentList>()!;
        }

        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPathList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPathList UriPath
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPathList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArgumentsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllQueryArgumentsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BodyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CookiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerOrderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaderOrder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HeaderOrderInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaders" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ja3FingerprintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa3Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ja3FingerprintInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ja4FingerprintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJa4Fingerprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ja4FingerprintInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBody" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jsonBodyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchJsonBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JsonBodyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SingleHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgumentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SingleQueryArgumentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriFragmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriFragment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UriFragmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UriPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch\"}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
