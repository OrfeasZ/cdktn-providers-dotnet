using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleTransformUrlRewriteConfigRewrite), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewrite")]
    public interface IAlbListenerRuleTransformUrlRewriteConfigRewrite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#regex AlbListenerRule#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        string Regex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#replace AlbListenerRule#replace}.</summary>
        [JsiiProperty(name: "replace", typeJson: "{\"primitive\":\"string\"}")]
        string Replace
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleTransformUrlRewriteConfigRewrite), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewrite")]
        internal sealed class _Proxy : DeputyBase, aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#regex AlbListenerRule#regex}.</summary>
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
            public string Regex
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#replace AlbListenerRule#replace}.</summary>
            [JsiiProperty(name: "replace", typeJson: "{\"primitive\":\"string\"}")]
            public string Replace
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
