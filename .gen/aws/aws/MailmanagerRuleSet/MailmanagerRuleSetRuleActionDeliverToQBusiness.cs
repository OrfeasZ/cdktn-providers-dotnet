using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionDeliverToQBusiness")]
    public class MailmanagerRuleSetRuleActionDeliverToQBusiness : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionDeliverToQBusiness
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#application_id MailmanagerRuleSet#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApplicationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#index_id MailmanagerRuleSet#index_id}.</summary>
        [JsiiProperty(name: "indexId", typeJson: "{\"primitive\":\"string\"}")]
        public string IndexId
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
