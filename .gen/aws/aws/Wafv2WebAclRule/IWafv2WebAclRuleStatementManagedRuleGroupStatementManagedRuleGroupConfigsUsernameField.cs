using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#identifier Wafv2WebAclRuleA#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        string Identifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#identifier Wafv2WebAclRuleA#identifier}.</summary>
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
            public string Identifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
