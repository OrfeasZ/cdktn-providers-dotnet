using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleTransform), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransform")]
    public interface IAlbListenerRuleTransform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#type AlbListenerRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>host_header_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#host_header_rewrite_config AlbListenerRule#host_header_rewrite_config}
        /// </remarks>
        [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#url_rewrite_config AlbListenerRule#url_rewrite_config}
        /// </remarks>
        [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig? UrlRewriteConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleTransform), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransform")]
        internal sealed class _Proxy : DeputyBase, aws.AlbListenerRule.IAlbListenerRuleTransform
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#type AlbListenerRule#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>host_header_rewrite_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#host_header_rewrite_config AlbListenerRule#host_header_rewrite_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfig\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig?>();
            }

            /// <summary>url_rewrite_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/alb_listener_rule#url_rewrite_config AlbListenerRule#url_rewrite_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
            public aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig? UrlRewriteConfig
            {
                get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig?>();
            }
        }
    }
}
