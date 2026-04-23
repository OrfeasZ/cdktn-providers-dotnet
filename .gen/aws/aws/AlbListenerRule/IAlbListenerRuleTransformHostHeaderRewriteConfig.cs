using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleTransformHostHeaderRewriteConfig), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfig")]
    public interface IAlbListenerRuleTransformHostHeaderRewriteConfig
    {
        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#rewrite AlbListenerRule#rewrite}
        /// </remarks>
        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfigRewrite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfigRewrite? Rewrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleTransformHostHeaderRewriteConfig), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rewrite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#rewrite AlbListenerRule#rewrite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfigRewrite\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfigRewrite? Rewrite
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfigRewrite?>();
            }
        }
    }
}
