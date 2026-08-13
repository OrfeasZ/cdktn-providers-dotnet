using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleActionsModifyRequestHeader), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsModifyRequestHeader")]
    public interface ICdnFrontdoorRuleActionsModifyRequestHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#header_name CdnFrontdoorRule#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#operator CdnFrontdoorRule#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#header_value CdnFrontdoorRule#header_value}.</summary>
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeaderValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleActionsModifyRequestHeader), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsModifyRequestHeader")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsModifyRequestHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#header_name CdnFrontdoorRule#header_name}.</summary>
            [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#operator CdnFrontdoorRule#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_rule#header_value CdnFrontdoorRule#header_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
