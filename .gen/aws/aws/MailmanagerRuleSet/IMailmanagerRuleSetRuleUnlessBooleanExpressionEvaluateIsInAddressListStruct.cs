using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct")]
    public interface IMailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#address_lists MailmanagerRuleSet#address_lists}.</summary>
        [JsiiProperty(name: "addressLists", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AddressLists
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        string Attribute
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessBooleanExpressionEvaluateIsInAddressListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#address_lists MailmanagerRuleSet#address_lists}.</summary>
            [JsiiProperty(name: "addressLists", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AddressLists
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
            public string Attribute
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
