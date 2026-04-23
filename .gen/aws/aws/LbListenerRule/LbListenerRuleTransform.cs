using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lbListenerRule.LbListenerRuleTransform")]
    public class LbListenerRuleTransform : aws.LbListenerRule.ILbListenerRuleTransform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#type LbListenerRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>host_header_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#host_header_rewrite_config LbListenerRule#host_header_rewrite_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfig\"}", isOptional: true)]
        public aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig
        {
            get;
            set;
        }

        /// <summary>url_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lb_listener_rule#url_rewrite_config LbListenerRule#url_rewrite_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
        public aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig? UrlRewriteConfig
        {
            get;
            set;
        }
    }
}
