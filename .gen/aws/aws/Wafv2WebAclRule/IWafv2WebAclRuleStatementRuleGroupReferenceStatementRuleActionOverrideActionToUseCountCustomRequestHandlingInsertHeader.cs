using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader")]
    public interface IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#value Wafv2WebAclRuleA#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementRuleGroupReferenceStatementRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#name Wafv2WebAclRuleA#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/wafv2_web_acl_rule#value Wafv2WebAclRuleA#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
