using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.XrayIndexingRule
{
    [JsiiInterface(nativeType: typeof(IXrayIndexingRuleRuleProbabilistic), fullyQualifiedName: "aws.xrayIndexingRule.XrayIndexingRuleRuleProbabilistic")]
    public interface IXrayIndexingRuleRuleProbabilistic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/xray_indexing_rule#desired_sampling_percentage XrayIndexingRule#desired_sampling_percentage}.</summary>
        [JsiiProperty(name: "desiredSamplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
        double DesiredSamplingPercentage
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IXrayIndexingRuleRuleProbabilistic), fullyQualifiedName: "aws.xrayIndexingRule.XrayIndexingRuleRuleProbabilistic")]
        internal sealed class _Proxy : DeputyBase, aws.XrayIndexingRule.IXrayIndexingRuleRuleProbabilistic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/xray_indexing_rule#desired_sampling_percentage XrayIndexingRule#desired_sampling_percentage}.</summary>
            [JsiiProperty(name: "desiredSamplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
            public double DesiredSamplingPercentage
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
