using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis")]
    public interface IMailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_rule_set#analyzer MailmanagerRuleSet#analyzer}.</summary>
        [JsiiProperty(name: "analyzer", typeJson: "{\"primitive\":\"string\"}")]
        string Analyzer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_rule_set#result_field MailmanagerRuleSet#result_field}.</summary>
        [JsiiProperty(name: "resultField", typeJson: "{\"primitive\":\"string\"}")]
        string ResultField
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_rule_set#analyzer MailmanagerRuleSet#analyzer}.</summary>
            [JsiiProperty(name: "analyzer", typeJson: "{\"primitive\":\"string\"}")]
            public string Analyzer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_rule_set#result_field MailmanagerRuleSet#result_field}.</summary>
            [JsiiProperty(name: "resultField", typeJson: "{\"primitive\":\"string\"}")]
            public string ResultField
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
