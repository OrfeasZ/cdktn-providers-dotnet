using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleTransform), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransform")]
    public interface IDataAwsLbListenerRuleTransform
    {
        /// <summary>host_header_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#host_header_rewrite_config DataAwsLbListenerRule#host_header_rewrite_config}
        /// </remarks>
        [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformHostHeaderRewriteConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostHeaderRewriteConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#url_rewrite_config DataAwsLbListenerRule#url_rewrite_config}
        /// </remarks>
        [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UrlRewriteConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleTransform), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransform")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransform
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>host_header_rewrite_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#host_header_rewrite_config DataAwsLbListenerRule#host_header_rewrite_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformHostHeaderRewriteConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostHeaderRewriteConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_rewrite_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#url_rewrite_config DataAwsLbListenerRule#url_rewrite_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UrlRewriteConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
