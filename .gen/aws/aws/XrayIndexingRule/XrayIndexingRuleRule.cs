using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.XrayIndexingRule
{
    [JsiiByValue(fqn: "aws.xrayIndexingRule.XrayIndexingRuleRule")]
    public class XrayIndexingRuleRule : aws.XrayIndexingRule.IXrayIndexingRuleRule
    {
        private object? _probabilistic;

        /// <summary>probabilistic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/xray_indexing_rule#probabilistic XrayIndexingRule#probabilistic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "probabilistic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.xrayIndexingRule.XrayIndexingRuleRuleProbabilistic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Probabilistic
        {
            get => _probabilistic;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.XrayIndexingRule.IXrayIndexingRuleRuleProbabilistic[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.XrayIndexingRule.IXrayIndexingRuleRuleProbabilistic).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _probabilistic = value;
            }
        }
    }
}
