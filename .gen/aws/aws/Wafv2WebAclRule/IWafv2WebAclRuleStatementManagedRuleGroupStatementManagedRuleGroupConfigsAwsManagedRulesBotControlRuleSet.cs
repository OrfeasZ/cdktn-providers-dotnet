using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRule
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#inspection_level Wafv2WebAclRuleA#inspection_level}.</summary>
        [JsiiProperty(name: "inspectionLevel", typeJson: "{\"primitive\":\"string\"}")]
        string InspectionLevel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#enable_machine_learning Wafv2WebAclRuleA#enable_machine_learning}.</summary>
        [JsiiProperty(name: "enableMachineLearning", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableMachineLearning
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet), fullyQualifiedName: "aws.wafv2WebAclRule.Wafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRule.IWafv2WebAclRuleStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#inspection_level Wafv2WebAclRuleA#inspection_level}.</summary>
            [JsiiProperty(name: "inspectionLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string InspectionLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule#enable_machine_learning Wafv2WebAclRuleA#enable_machine_learning}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableMachineLearning", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableMachineLearning
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
