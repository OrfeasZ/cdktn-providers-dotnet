using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleConditionIpExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionIpExpressionEvaluate")]
    public interface IMailmanagerRuleSetRuleConditionIpExpressionEvaluate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        string Attribute
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleConditionIpExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionIpExpressionEvaluate")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionIpExpressionEvaluate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
            public string Attribute
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
