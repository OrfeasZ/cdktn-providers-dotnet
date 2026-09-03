using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionAddHeader")]
    public class MailmanagerRuleSetRuleActionAddHeader : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionAddHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#header_name MailmanagerRuleSet#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#header_value MailmanagerRuleSet#header_value}.</summary>
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderValue
        {
            get;
            set;
        }
    }
}
