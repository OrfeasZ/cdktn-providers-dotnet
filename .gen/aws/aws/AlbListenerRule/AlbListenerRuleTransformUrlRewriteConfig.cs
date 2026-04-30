using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiByValue(fqn: "aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig")]
    public class AlbListenerRuleTransformUrlRewriteConfig : aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig
    {
        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#rewrite AlbListenerRule#rewrite}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewrite\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite? Rewrite
        {
            get;
            set;
        }
    }
}
