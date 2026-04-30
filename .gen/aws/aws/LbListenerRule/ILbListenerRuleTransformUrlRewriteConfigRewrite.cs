using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleTransformUrlRewriteConfigRewrite), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewrite")]
    public interface ILbListenerRuleTransformUrlRewriteConfigRewrite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#regex LbListenerRule#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        string Regex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#replace LbListenerRule#replace}.</summary>
        [JsiiProperty(name: "replace", typeJson: "{\"primitive\":\"string\"}")]
        string Replace
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleTransformUrlRewriteConfigRewrite), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewrite")]
        internal sealed class _Proxy : DeputyBase, aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#regex LbListenerRule#regex}.</summary>
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
            public string Regex
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lb_listener_rule#replace LbListenerRule#replace}.</summary>
            [JsiiProperty(name: "replace", typeJson: "{\"primitive\":\"string\"}")]
            public string Replace
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
