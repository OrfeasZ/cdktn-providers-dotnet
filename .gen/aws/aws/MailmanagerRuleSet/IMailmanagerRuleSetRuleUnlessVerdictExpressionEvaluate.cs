using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate")]
    public interface IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate
    {
        /// <summary>analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#analysis MailmanagerRuleSet#analysis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluateAnalysis" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Analysis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>analysis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#analysis MailmanagerRuleSet#analysis}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpressionEvaluateAnalysis" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Analysis
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attribute
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
