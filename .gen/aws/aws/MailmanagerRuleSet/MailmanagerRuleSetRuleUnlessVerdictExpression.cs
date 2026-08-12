using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpression")]
    public class MailmanagerRuleSetRuleUnlessVerdictExpression : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#operator MailmanagerRuleSet#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#values MailmanagerRuleSet#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }

        private object? _evaluate;

        /// <summary>evaluate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#evaluate MailmanagerRuleSet#evaluate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evaluate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Evaluate
        {
            get => _evaluate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _evaluate = value;
            }
        }
    }
}
