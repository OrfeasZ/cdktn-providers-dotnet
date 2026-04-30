using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.albListenerRule.AlbListenerRuleTransform")]
    public class AlbListenerRuleTransform : aws.AlbListenerRule.IAlbListenerRuleTransform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#type AlbListenerRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>host_header_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#host_header_rewrite_config AlbListenerRule#host_header_rewrite_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfig\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig
        {
            get;
            set;
        }

        /// <summary>url_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#url_rewrite_config AlbListenerRule#url_rewrite_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
        public aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig? UrlRewriteConfig
        {
            get;
            set;
        }
    }
}
