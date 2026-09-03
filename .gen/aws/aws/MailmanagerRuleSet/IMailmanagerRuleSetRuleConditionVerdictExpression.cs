using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleConditionVerdictExpression), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionVerdictExpression")]
    public interface IMailmanagerRuleSetRuleConditionVerdictExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#operator MailmanagerRuleSet#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#values MailmanagerRuleSet#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>evaluate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#evaluate MailmanagerRuleSet#evaluate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionVerdictExpressionEvaluate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "evaluate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionVerdictExpressionEvaluate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Evaluate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleConditionVerdictExpression), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionVerdictExpression")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionVerdictExpression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#operator MailmanagerRuleSet#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#values MailmanagerRuleSet#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>evaluate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#evaluate MailmanagerRuleSet#evaluate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionVerdictExpressionEvaluate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "evaluate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionVerdictExpressionEvaluate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Evaluate
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
