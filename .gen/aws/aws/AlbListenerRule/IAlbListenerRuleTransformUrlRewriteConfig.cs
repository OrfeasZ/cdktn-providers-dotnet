using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleTransformUrlRewriteConfig), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig")]
    public interface IAlbListenerRuleTransformUrlRewriteConfig
    {
        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#rewrite AlbListenerRule#rewrite}
        /// </remarks>
        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewrite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite? Rewrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleTransformUrlRewriteConfig), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rewrite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/alb_listener_rule#rewrite AlbListenerRule#rewrite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewrite\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite? Rewrite
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite?>();
            }
        }
    }
}
