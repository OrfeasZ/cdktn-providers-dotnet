using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementByteMatchStatementFieldToMatchBody), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementByteMatchStatementFieldToMatchBody")]
    public interface IWafv2WebAclRuleStatementByteMatchStatementFieldToMatchBody
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#oversize_handling Wafv2WebAclRuleA#oversize_handling}.</summary>
        [JsiiProperty(name: "oversizeHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OversizeHandling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementByteMatchStatementFieldToMatchBody), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementByteMatchStatementFieldToMatchBody")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementByteMatchStatementFieldToMatchBody
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#oversize_handling Wafv2WebAclRuleA#oversize_handling}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oversizeHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OversizeHandling
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
