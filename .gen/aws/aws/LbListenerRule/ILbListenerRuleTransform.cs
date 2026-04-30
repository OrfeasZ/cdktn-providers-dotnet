using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleTransform), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransform")]
    public interface ILbListenerRuleTransform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#type LbListenerRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>host_header_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#host_header_rewrite_config LbListenerRule#host_header_rewrite_config}
        /// </remarks>
        [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#url_rewrite_config LbListenerRule#url_rewrite_config}
        /// </remarks>
        [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig? UrlRewriteConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleTransform), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransform")]
        internal sealed class _Proxy : DeputyBase, aws.LbListenerRule.ILbListenerRuleTransform
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#type LbListenerRule#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>host_header_rewrite_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#host_header_rewrite_config LbListenerRule#host_header_rewrite_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfig\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig?>();
            }

            /// <summary>url_rewrite_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#url_rewrite_config LbListenerRule#url_rewrite_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig? UrlRewriteConfig
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig?>();
            }
        }
    }
}
