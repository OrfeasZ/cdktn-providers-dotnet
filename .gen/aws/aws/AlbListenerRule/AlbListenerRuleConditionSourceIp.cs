using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiByValue(fqn: "aws.albListenerRule.AlbListenerRuleConditionSourceIp")]
    public class AlbListenerRuleConditionSourceIp : aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/alb_listener_rule#ip_address_type AlbListenerRule#ip_address_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddressType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/alb_listener_rule#values AlbListenerRule#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
