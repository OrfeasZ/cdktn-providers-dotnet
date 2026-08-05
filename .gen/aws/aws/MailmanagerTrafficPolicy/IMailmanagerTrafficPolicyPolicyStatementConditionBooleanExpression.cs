using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    [JsiiInterface(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression")]
    public interface IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#operator MailmanagerTrafficPolicy#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>evaluate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#evaluate MailmanagerTrafficPolicy#evaluate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "evaluate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Evaluate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#operator MailmanagerTrafficPolicy#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>evaluate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#evaluate MailmanagerTrafficPolicy#evaluate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "evaluate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpressionEvaluate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Evaluate
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
