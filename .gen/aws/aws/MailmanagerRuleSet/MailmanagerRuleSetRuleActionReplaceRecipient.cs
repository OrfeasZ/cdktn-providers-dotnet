using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionReplaceRecipient")]
    public class MailmanagerRuleSetRuleActionReplaceRecipient : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionReplaceRecipient
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_rule_set#replace_with MailmanagerRuleSet#replace_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replaceWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ReplaceWith
        {
            get;
            set;
        }
    }
}
