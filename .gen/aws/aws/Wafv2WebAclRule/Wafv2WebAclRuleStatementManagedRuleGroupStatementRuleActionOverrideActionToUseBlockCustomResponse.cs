using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseBlockCustomResponse")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseBlockCustomResponse : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseBlockCustomResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#response_code Wafv2WebAclRuleA#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}")]
        public double ResponseCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#custom_response_body_key Wafv2WebAclRuleA#custom_response_body_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomResponseBodyKey
        {
            get;
            set;
        }

        private object? _responseHeader;

        /// <summary>response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#response_header Wafv2WebAclRuleA#response_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResponseHeader
        {
            get => _responseHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseBlockCustomResponseResponseHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementRuleActionOverrideActionToUseBlockCustomResponseResponseHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _responseHeader = value;
            }
        }
    }
}
