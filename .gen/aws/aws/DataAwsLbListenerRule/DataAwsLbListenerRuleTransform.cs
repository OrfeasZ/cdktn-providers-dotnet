using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiByValue(fqn: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransform")]
    public class DataAwsLbListenerRuleTransform : aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransform
    {
        private object? _hostHeaderRewriteConfig;

        /// <summary>host_header_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/lb_listener_rule#host_header_rewrite_config DataAwsLbListenerRule#host_header_rewrite_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformHostHeaderRewriteConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HostHeaderRewriteConfig
        {
            get => _hostHeaderRewriteConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformHostHeaderRewriteConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformHostHeaderRewriteConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hostHeaderRewriteConfig = value;
            }
        }

        private object? _urlRewriteConfig;

        /// <summary>url_rewrite_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/lb_listener_rule#url_rewrite_config DataAwsLbListenerRule#url_rewrite_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UrlRewriteConfig
        {
            get => _urlRewriteConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformUrlRewriteConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformUrlRewriteConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlRewriteConfig = value;
            }
        }
    }
}
