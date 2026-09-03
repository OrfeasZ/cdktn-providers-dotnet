using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleActionReplaceRecipient), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionReplaceRecipient")]
    public interface IMailmanagerRuleSetRuleActionReplaceRecipient
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#replace_with MailmanagerRuleSet#replace_with}.</summary>
        [JsiiProperty(name: "replaceWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReplaceWith
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleActionReplaceRecipient), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionReplaceRecipient")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionReplaceRecipient
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#replace_with MailmanagerRuleSet#replace_with}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replaceWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReplaceWith
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
