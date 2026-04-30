using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleGroupAssociationVisibilityConfig), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationVisibilityConfig")]
    public interface IWafv2WebAclRuleGroupAssociationVisibilityConfig
    {
        /// <summary>Indicates whether the rule is available for use in the metrics for the web ACL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#cloudwatch_metrics_enabled Wafv2WebAclRuleGroupAssociation#cloudwatch_metrics_enabled}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object CloudwatchMetricsEnabled
        {
            get;
        }

        /// <summary>A name for the metrics for this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#metric_name Wafv2WebAclRuleGroupAssociation#metric_name}
        /// </remarks>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        /// <summary>Indicates whether to store a sampling of the web requests that match the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#sampled_requests_enabled Wafv2WebAclRuleGroupAssociation#sampled_requests_enabled}
        /// </remarks>
        [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object SampledRequestsEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleGroupAssociationVisibilityConfig), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationVisibilityConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationVisibilityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates whether the rule is available for use in the metrics for the web ACL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#cloudwatch_metrics_enabled Wafv2WebAclRuleGroupAssociation#cloudwatch_metrics_enabled}
            /// </remarks>
            [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object CloudwatchMetricsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>A name for the metrics for this rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#metric_name Wafv2WebAclRuleGroupAssociation#metric_name}
            /// </remarks>
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Indicates whether to store a sampling of the web requests that match the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#sampled_requests_enabled Wafv2WebAclRuleGroupAssociation#sampled_requests_enabled}
            /// </remarks>
            [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object SampledRequestsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
