using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#failure_codes Wafv2WebAclRuleA#failure_codes}.</summary>
        [JsiiProperty(name: "failureCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] FailureCodes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#success_codes Wafv2WebAclRuleA#success_codes}.</summary>
        [JsiiProperty(name: "successCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] SuccessCodes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#failure_codes Wafv2WebAclRuleA#failure_codes}.</summary>
            [JsiiProperty(name: "failureCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] FailureCodes
            {
                get => GetInstanceProperty<double[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#success_codes Wafv2WebAclRuleA#success_codes}.</summary>
            [JsiiProperty(name: "successCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] SuccessCodes
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
