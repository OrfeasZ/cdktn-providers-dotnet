using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessIpExpressionEvaluate")]
    public class MailmanagerRuleSetRuleUnlessIpExpressionEvaluate : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessIpExpressionEvaluate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        public string Attribute
        {
            get;
            set;
        }
    }
}
