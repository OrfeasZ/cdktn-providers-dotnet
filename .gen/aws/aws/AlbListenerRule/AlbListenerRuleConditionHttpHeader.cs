using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.albListenerRule.AlbListenerRuleConditionHttpHeader")]
    public class AlbListenerRuleConditionHttpHeader : aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#http_header_name AlbListenerRule#http_header_name}.</summary>
        [JsiiProperty(name: "httpHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpHeaderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#regex_values AlbListenerRule#regex_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regexValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RegexValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#values AlbListenerRule#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
