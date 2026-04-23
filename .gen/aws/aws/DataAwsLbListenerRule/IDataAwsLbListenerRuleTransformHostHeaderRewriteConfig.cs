using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleTransformHostHeaderRewriteConfig), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformHostHeaderRewriteConfig")]
    public interface IDataAwsLbListenerRuleTransformHostHeaderRewriteConfig
    {
        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#rewrite DataAwsLbListenerRule#rewrite}
        /// </remarks>
        [JsiiProperty(name: "rewrite", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformHostHeaderRewriteConfigRewrite\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rewrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleTransformHostHeaderRewriteConfig), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformHostHeaderRewriteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformHostHeaderRewriteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rewrite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/lb_listener_rule#rewrite DataAwsLbListenerRule#rewrite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rewrite", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformHostHeaderRewriteConfigRewrite\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rewrite
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
