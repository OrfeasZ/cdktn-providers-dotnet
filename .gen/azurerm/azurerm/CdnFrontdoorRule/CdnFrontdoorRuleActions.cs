using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiByValue(fqn: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActions")]
    public class CdnFrontdoorRuleActions : azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActions
    {
        private object? _modifyRequestHeader;

        /// <summary>modify_request_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#modify_request_header CdnFrontdoorRule#modify_request_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsModifyRequestHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifyRequestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsModifyRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ModifyRequestHeader
        {
            get => _modifyRequestHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsModifyRequestHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsModifyRequestHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modifyRequestHeader = value;
            }
        }

        private object? _modifyResponseHeader;

        /// <summary>modify_response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#modify_response_header CdnFrontdoorRule#modify_response_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsModifyResponseHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifyResponseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsModifyResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ModifyResponseHeader
        {
            get => _modifyResponseHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsModifyResponseHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsModifyResponseHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modifyResponseHeader = value;
            }
        }

        /// <summary>route_configuration_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#route_configuration_override CdnFrontdoorRule#route_configuration_override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeConfigurationOverride", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverride\"}", isOptional: true)]
        public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverride? RouteConfigurationOverride
        {
            get;
            set;
        }

        /// <summary>url_redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#url_redirect CdnFrontdoorRule#url_redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRedirect", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirect\"}", isOptional: true)]
        public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRedirect? UrlRedirect
        {
            get;
            set;
        }

        /// <summary>url_rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#url_rewrite CdnFrontdoorRule#url_rewrite}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlRewrite", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewrite\"}", isOptional: true)]
        public azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRewrite? UrlRewrite
        {
            get;
            set;
        }
    }
}
