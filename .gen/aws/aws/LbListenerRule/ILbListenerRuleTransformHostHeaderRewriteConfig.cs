using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleTransformHostHeaderRewriteConfig), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfig")]
    public interface ILbListenerRuleTransformHostHeaderRewriteConfig
    {
        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#rewrite LbListenerRule#rewrite}
        /// </remarks>
        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfigRewrite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfigRewrite? Rewrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleTransformHostHeaderRewriteConfig), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rewrite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#rewrite LbListenerRule#rewrite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfigRewrite\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfigRewrite? Rewrite
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfigRewrite?>();
            }
        }
    }
}
