using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseCaptcha")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseCaptcha : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseCaptcha
    {
        private object? _customRequestHandling;

        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#custom_request_handling Wafv2WebAclRuleA#custom_request_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseCaptchaCustomRequestHandling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomRequestHandling
        {
            get => _customRequestHandling;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseCaptchaCustomRequestHandling[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseCaptchaCustomRequestHandling).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customRequestHandling = value;
            }
        }
    }
}
