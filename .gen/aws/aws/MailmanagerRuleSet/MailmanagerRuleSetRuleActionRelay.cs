using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionRelay")]
    public class MailmanagerRuleSetRuleActionRelay : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionRelay
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_rule_set#relay MailmanagerRuleSet#relay}.</summary>
        [JsiiProperty(name: "relay", typeJson: "{\"primitive\":\"string\"}")]
        public string Relay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_rule_set#action_failure_policy MailmanagerRuleSet#action_failure_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionFailurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionFailurePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_rule_set#mail_from MailmanagerRuleSet#mail_from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mailFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MailFrom
        {
            get;
            set;
        }
    }
}
