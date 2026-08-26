using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct")]
    public class MailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#address_lists MailmanagerRuleSet#address_lists}.</summary>
        [JsiiProperty(name: "addressLists", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AddressLists
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        public string Attribute
        {
            get;
            set;
        }
    }
}
