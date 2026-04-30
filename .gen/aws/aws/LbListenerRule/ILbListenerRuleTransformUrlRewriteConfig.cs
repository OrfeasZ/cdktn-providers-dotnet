using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleTransformUrlRewriteConfig), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfig")]
    public interface ILbListenerRuleTransformUrlRewriteConfig
    {
        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#rewrite LbListenerRule#rewrite}
        /// </remarks>
        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewrite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite? Rewrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleTransformUrlRewriteConfig), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rewrite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#rewrite LbListenerRule#rewrite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewrite\"}", isOptional: true)]
            public aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite? Rewrite
            {
                get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite?>();
            }
        }
    }
}
