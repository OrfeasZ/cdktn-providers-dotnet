using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement
    {
        /// <summary>Area within the portion of a web request that you want AWS WAF to search for SearchString.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#positional_constraint Wafv2WebAclRuleA#positional_constraint}
        /// </remarks>
        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public string PositionalConstraint
        {
            get;
            set;
        }

        /// <summary>String value to search for within the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#search_string Wafv2WebAclRuleA#search_string}
        /// </remarks>
        [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}")]
        public string SearchString
        {
            get;
            set;
        }

        private object? _fieldToMatch;

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#field_to_match Wafv2WebAclRuleA#field_to_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementFieldToMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FieldToMatch
        {
            get => _fieldToMatch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementFieldToMatch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementFieldToMatch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldToMatch = value;
            }
        }

        private object? _textTransformation;

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#text_transformation Wafv2WebAclRuleA#text_transformation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TextTransformation
        {
            get => _textTransformation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementTextTransformation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementTextTransformation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _textTransformation = value;
            }
        }
    }
}
