using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirect")]
    public interface ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#redirect_type CdnFrontdoorBatchRuleSet#redirect_type}.</summary>
        [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
        string RedirectType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_fragment CdnFrontdoorBatchRuleSet#destination_fragment}.</summary>
        [JsiiProperty(name: "destinationFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationFragment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_host_name CdnFrontdoorBatchRuleSet#destination_host_name}.</summary>
        [JsiiProperty(name: "destinationHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationHostName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_path CdnFrontdoorBatchRuleSet#destination_path}.</summary>
        [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#query_string CdnFrontdoorBatchRuleSet#query_string}.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#redirect_protocol CdnFrontdoorBatchRuleSet#redirect_protocol}.</summary>
        [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedirectProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleActionsUrlRedirect")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleActionsUrlRedirect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#redirect_type CdnFrontdoorBatchRuleSet#redirect_type}.</summary>
            [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
            public string RedirectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_fragment CdnFrontdoorBatchRuleSet#destination_fragment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationFragment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_host_name CdnFrontdoorBatchRuleSet#destination_host_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationHostName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#destination_path CdnFrontdoorBatchRuleSet#destination_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#query_string CdnFrontdoorBatchRuleSet#query_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_batch_rule_set#redirect_protocol CdnFrontdoorBatchRuleSet#redirect_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedirectProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
