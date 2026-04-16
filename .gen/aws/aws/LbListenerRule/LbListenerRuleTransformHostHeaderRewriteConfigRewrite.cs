using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfigRewrite")]
    public class LbListenerRuleTransformHostHeaderRewriteConfigRewrite : aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfigRewrite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener_rule#regex LbListenerRule#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        public string Regex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener_rule#replace LbListenerRule#replace}.</summary>
        [JsiiProperty(name: "replace", typeJson: "{\"primitive\":\"string\"}")]
        public string Replace
        {
            get;
            set;
        }
    }
}
