using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSqliMatchStatement")]
    public class Wafv2WebAclRuleStatementSqliMatchStatement : aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementSqliMatchStatement
    {
        private object? _fieldToMatch;

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#field_to_match Wafv2WebAclRuleA#field_to_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSqliMatchStatementFieldToMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementSqliMatchStatementFieldToMatch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementSqliMatchStatementFieldToMatch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldToMatch = value;
            }
        }

        /// <summary>Sensitivity level for detecting SQL injection attacks. Valid values: `HIGH`, `LOW`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#sensitivity_level Wafv2WebAclRuleA#sensitivity_level}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sensitivityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SensitivityLevel
        {
            get;
            set;
        }

        private object? _textTransformation;

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule#text_transformation Wafv2WebAclRuleA#text_transformation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementSqliMatchStatementTextTransformation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementSqliMatchStatementTextTransformation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _textTransformation = value;
            }
        }
    }
}
