using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclRuleGroupAssociation
{
    [JsiiByValue(fqn: "aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection")]
    public class Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection : aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection
    {
        private object? _bodyContains;

        /// <summary>body_contains block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#body_contains Wafv2WebAclRuleGroupAssociation#body_contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bodyContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BodyContains
        {
            get => _bodyContains;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bodyContains = value;
            }
        }

        private object? _header;

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#header Wafv2WebAclRuleGroupAssociation#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Header
        {
            get => _header;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _header = value;
            }
        }

        private object? _json;

        /// <summary>json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#json Wafv2WebAclRuleGroupAssociation#json}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Json
        {
            get => _json;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _json = value;
            }
        }

        private object? _statusCode;

        /// <summary>status_code block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/wafv2_web_acl_rule_group_association#status_code Wafv2WebAclRuleGroupAssociation#status_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclRuleGroupAssociation.Wafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StatusCode
        {
            get => _statusCode;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2WebAclRuleGroupAssociation.IWafv2WebAclRuleGroupAssociationManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _statusCode = value;
            }
        }
    }
}
