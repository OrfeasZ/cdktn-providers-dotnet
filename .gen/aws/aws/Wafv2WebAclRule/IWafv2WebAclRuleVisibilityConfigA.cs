using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleVisibilityConfigA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleVisibilityConfigA")]
    public interface IWafv2WebAclRuleVisibilityConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#cloudwatch_metrics_enabled Wafv2WebAclRuleA#cloudwatch_metrics_enabled}.</summary>
        [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object CloudwatchMetricsEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#metric_name Wafv2WebAclRuleA#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#sampled_requests_enabled Wafv2WebAclRuleA#sampled_requests_enabled}.</summary>
        [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object SampledRequestsEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleVisibilityConfigA), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleVisibilityConfigA")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleVisibilityConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#cloudwatch_metrics_enabled Wafv2WebAclRuleA#cloudwatch_metrics_enabled}.</summary>
            [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object CloudwatchMetricsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#metric_name Wafv2WebAclRuleA#metric_name}.</summary>
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#sampled_requests_enabled Wafv2WebAclRuleA#sampled_requests_enabled}.</summary>
            [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object SampledRequestsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
