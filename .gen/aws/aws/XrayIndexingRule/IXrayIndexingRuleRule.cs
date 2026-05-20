using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.XrayIndexingRule
{
    [JsiiInterface(nativeType: typeof(IXrayIndexingRuleRule), fullyQualifiedName: "aws.xrayIndexingRule.XrayIndexingRuleRule")]
    public interface IXrayIndexingRuleRule
    {
        /// <summary>probabilistic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/xray_indexing_rule#probabilistic XrayIndexingRule#probabilistic}
        /// </remarks>
        [JsiiProperty(name: "probabilistic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.xrayIndexingRule.XrayIndexingRuleRuleProbabilistic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Probabilistic
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IXrayIndexingRuleRule), fullyQualifiedName: "aws.xrayIndexingRule.XrayIndexingRuleRule")]
        internal sealed class _Proxy : DeputyBase, aws.XrayIndexingRule.IXrayIndexingRuleRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>probabilistic block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/xray_indexing_rule#probabilistic XrayIndexingRule#probabilistic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "probabilistic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.xrayIndexingRule.XrayIndexingRuleRuleProbabilistic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Probabilistic
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
