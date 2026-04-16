using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiByValue(fqn: "aws.lbListenerRule.LbListenerRuleConditionHostHeader")]
    public class LbListenerRuleConditionHostHeader : aws.LbListenerRule.ILbListenerRuleConditionHostHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener_rule#regex_values LbListenerRule#regex_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regexValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RegexValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener_rule#values LbListenerRule#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
