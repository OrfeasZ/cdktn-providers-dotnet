using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionDeliverToMailbox")]
    public class MailmanagerRuleSetRuleActionDeliverToMailbox : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionDeliverToMailbox
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#mailbox_arn MailmanagerRuleSet#mailbox_arn}.</summary>
        [JsiiProperty(name: "mailboxArn", typeJson: "{\"primitive\":\"string\"}")]
        public string MailboxArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#role_arn MailmanagerRuleSet#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#action_failure_policy MailmanagerRuleSet#action_failure_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionFailurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionFailurePolicy
        {
            get;
            set;
        }
    }
}
