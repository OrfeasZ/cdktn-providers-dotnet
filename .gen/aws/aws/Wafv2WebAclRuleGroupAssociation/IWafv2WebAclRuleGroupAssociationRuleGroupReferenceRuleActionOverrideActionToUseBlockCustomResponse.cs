using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse")]
    public interface IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#response_code Wafv2WebAclRuleGroupAssociation#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}")]
        double ResponseCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#custom_response_body_key Wafv2WebAclRuleGroupAssociation#custom_response_body_key}.</summary>
        [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomResponseBodyKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#response_header Wafv2WebAclRuleGroupAssociation#response_header}
        /// </remarks>
        [JsiiProperty(name: "responseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResponseHeader
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse), fullyQualifiedName: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#response_code Wafv2WebAclRuleGroupAssociation#response_code}.</summary>
            [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}")]
            public double ResponseCode
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#custom_response_body_key Wafv2WebAclRuleGroupAssociation#custom_response_body_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomResponseBodyKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>response_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/wafv2_web_acl_rule_group_association#response_header Wafv2WebAclRuleGroupAssociation#response_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResponseHeader
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
