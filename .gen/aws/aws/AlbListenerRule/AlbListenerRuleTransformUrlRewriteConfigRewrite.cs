using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewrite")]
    public class AlbListenerRuleTransformUrlRewriteConfigRewrite : aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#regex AlbListenerRule#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        public string Regex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#replace AlbListenerRule#replace}.</summary>
        [JsiiProperty(name: "replace", typeJson: "{\"primitive\":\"string\"}")]
        public string Replace
        {
            get;
            set;
        }
    }
}
