using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiByValue(fqn: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfig")]
    public class DataAwsLbListenerRuleTransformUrlRewriteConfig : aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformUrlRewriteConfig
    {
        private object? _rewrite;

        /// <summary>rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#rewrite DataAwsLbListenerRule#rewrite}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rewrite", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleTransformUrlRewriteConfigRewrite\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rewrite
        {
            get => _rewrite;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformUrlRewriteConfigRewrite[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleTransformUrlRewriteConfigRewrite).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rewrite = value;
            }
        }
    }
}
