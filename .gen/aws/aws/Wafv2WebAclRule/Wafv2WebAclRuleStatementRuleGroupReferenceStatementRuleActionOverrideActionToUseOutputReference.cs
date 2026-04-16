using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseOutputReference), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllow", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllow\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllow(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllow[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllow).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllow).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlock\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBlock(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlock[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlock).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlock).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCaptcha", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptcha\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCaptcha(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptcha[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptcha).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptcha).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutChallenge(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllow")]
        public virtual void ResetAllow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlock")]
        public virtual void ResetBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptcha")]
        public virtual void ResetCaptcha()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChallenge")]
        public virtual void ResetChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCount")]
        public virtual void ResetCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllowList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllowList Allow
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllowList>()!;
        }

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlockList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlockList Block
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlockList>()!;
        }

        [JsiiProperty(name: "captcha", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptchaList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptchaList Captcha
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptchaList>()!;
        }

        [JsiiProperty(name: "challenge", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallengeList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallengeList Challenge
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallengeList>()!;
        }

        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountList\"}")]
        public virtual aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountList Count
        {
            get => GetInstanceProperty<aws.Wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlock\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BlockInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captchaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptcha\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CaptchaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "challengeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ChallengeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "countInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUse\"}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUse cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUse).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
