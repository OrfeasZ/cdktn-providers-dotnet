using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression")]
    public class MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression : aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_traffic_policy#operator MailmanagerTrafficPolicy#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        private object? _evaluate;

        /// <summary>evaluate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_traffic_policy#evaluate MailmanagerTrafficPolicy#evaluate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evaluate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _evaluate = value;
            }
        }
    }
}
