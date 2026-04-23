using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiByValue(fqn: "aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfig")]
    public class LbListenerRuleTransformHostHeaderRewriteConfig : aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig
    {
        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#rewrite LbListenerRule#rewrite}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfigRewrite\"}", isOptional: true)]
        public aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfigRewrite? Rewrite
        {
            get;
            set;
        }
    }
}
