using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    [JsiiByValue(fqn: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate")]
    public class MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate : aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate
    {
        private object? _analysis;

        /// <summary>analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_traffic_policy#analysis MailmanagerTrafficPolicy#analysis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluateAnalysis" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluateAnalysis[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluateAnalysis).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _analysis = value;
            }
        }

        private object? _isInAddressList;

        /// <summary>is_in_address_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_traffic_policy#is_in_address_list MailmanagerTrafficPolicy#is_in_address_list}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluateIsInAddressListStruct" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isInAddressList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluateIsInAddressListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluateIsInAddressListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluateIsInAddressListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isInAddressList = value;
            }
        }
    }
}
