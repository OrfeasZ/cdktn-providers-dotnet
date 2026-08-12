using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionBooleanExpressionEvaluate")]
    public class MailmanagerRuleSetRuleConditionBooleanExpressionEvaluate : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionBooleanExpressionEvaluate
    {
        private object? _analysis;

        /// <summary>analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#analysis MailmanagerRuleSet#analysis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionBooleanExpressionEvaluateAnalysis" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionBooleanExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Analysis
        {
            get => _analysis;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionBooleanExpressionEvaluateAnalysis[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionBooleanExpressionEvaluateAnalysis).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _analysis = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Attribute
        {
            get;
            set;
        }

        private object? _isInAddressList;

        /// <summary>is_in_address_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#is_in_address_list MailmanagerRuleSet#is_in_address_list}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionBooleanExpressionEvaluateIsInAddressListStruct" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isInAddressList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionBooleanExpressionEvaluateIsInAddressListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IsInAddressList
        {
            get => _isInAddressList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionBooleanExpressionEvaluateIsInAddressListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionBooleanExpressionEvaluateIsInAddressListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isInAddressList = value;
            }
        }
    }
}
