using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUse")]
    public class Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUse : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUse
    {
        private object? _allow;

        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#allow Wafv2WebAclRuleA#allow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Allow
        {
            get => _allow;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllow[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseAllow).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allow = value;
            }
        }

        private object? _block;

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#block Wafv2WebAclRuleA#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlock\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Block
        {
            get => _block;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlock[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseBlock).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _block = value;
            }
        }

        private object? _captcha;

        /// <summary>captcha block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#captcha Wafv2WebAclRuleA#captcha}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captcha", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptcha\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Captcha
        {
            get => _captcha;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptcha[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCaptcha).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _captcha = value;
            }
        }

        private object? _challenge;

        /// <summary>challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#challenge Wafv2WebAclRuleA#challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "challenge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Challenge
        {
            get => _challenge;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseChallenge).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _challenge = value;
            }
        }

        private object? _count;

        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#count Wafv2WebAclRuleA#count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }
    }
}
