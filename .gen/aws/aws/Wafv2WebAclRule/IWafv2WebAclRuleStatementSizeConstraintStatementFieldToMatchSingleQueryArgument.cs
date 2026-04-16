using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument")]
    public interface IWafv2WebAclRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument
    {
        /// <summary>Query argument name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementSizeConstraintStatementFieldToMatchSingleQueryArgument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Query argument name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
