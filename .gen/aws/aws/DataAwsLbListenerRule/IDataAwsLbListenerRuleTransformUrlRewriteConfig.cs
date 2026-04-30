using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleTransformUrlRewriteConfig), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfig")]
    public interface IDataAwsLbListenerRuleTransformUrlRewriteConfig
    {
        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#rewrite DataAwsLbListenerRule#rewrite}
        /// </remarks>
        [JsiiProperty(name: "rewrite", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfigRewrite\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rewrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleTransformUrlRewriteConfig), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformUrlRewriteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rewrite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#rewrite DataAwsLbListenerRule#rewrite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rewrite", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfigRewrite\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rewrite
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
