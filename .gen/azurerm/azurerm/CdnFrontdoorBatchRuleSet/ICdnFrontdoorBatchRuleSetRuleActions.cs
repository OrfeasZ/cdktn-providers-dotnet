using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorBatchRuleSetRuleActions), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActions")]
    public interface ICdnFrontdoorBatchRuleSetRuleActions
    {
        /// <summary>modify_request_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#modify_request_header CdnFrontdoorBatchRuleSet#modify_request_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "modifyRequestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ModifyRequestHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>modify_response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#modify_response_header CdnFrontdoorBatchRuleSet#modify_response_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "modifyResponseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ModifyResponseHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>route_configuration_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#route_configuration_override CdnFrontdoorBatchRuleSet#route_configuration_override}
        /// </remarks>
        [JsiiProperty(name: "routeConfigurationOverride", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride? RouteConfigurationOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#url_redirect CdnFrontdoorBatchRuleSet#url_redirect}
        /// </remarks>
        [JsiiProperty(name: "urlRedirect", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect? UrlRedirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_rewrite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#url_rewrite CdnFrontdoorBatchRuleSet#url_rewrite}
        /// </remarks>
        [JsiiProperty(name: "urlRewrite", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRewrite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRewrite? UrlRewrite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorBatchRuleSetRuleActions), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActions")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>modify_request_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#modify_request_header CdnFrontdoorBatchRuleSet#modify_request_header}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modifyRequestHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModifyRequestHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>modify_response_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#modify_response_header CdnFrontdoorBatchRuleSet#modify_response_header}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modifyResponseHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsModifyResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModifyResponseHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>route_configuration_override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#route_configuration_override CdnFrontdoorBatchRuleSet#route_configuration_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeConfigurationOverride", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride\"}", isOptional: true)]
            public azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride? RouteConfigurationOverride
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsRouteConfigurationOverride?>();
            }

            /// <summary>url_redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#url_redirect CdnFrontdoorBatchRuleSet#url_redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRedirect", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirect\"}", isOptional: true)]
            public azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect? UrlRedirect
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect?>();
            }

            /// <summary>url_rewrite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_batch_rule_set#url_rewrite CdnFrontdoorBatchRuleSet#url_rewrite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlRewrite", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRewrite\"}", isOptional: true)]
            public azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRewrite? UrlRewrite
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRewrite?>();
            }
        }
    }
}
