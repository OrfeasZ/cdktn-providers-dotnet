using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleActionsRouteConfigurationOverrideCaching), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideCaching")]
    public interface ICdnFrontdoorRuleActionsRouteConfigurationOverrideCaching
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#behaviour CdnFrontdoorRule#behaviour}.</summary>
        [JsiiProperty(name: "behaviour", typeJson: "{\"primitive\":\"string\"}")]
        string Behaviour
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#compression_enabled CdnFrontdoorRule#compression_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "compressionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CompressionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#duration CdnFrontdoorRule#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#query_string_behaviour CdnFrontdoorRule#query_string_behaviour}.</summary>
        [JsiiProperty(name: "queryStringBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryStringBehaviour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#query_string_parameters CdnFrontdoorRule#query_string_parameters}.</summary>
        [JsiiProperty(name: "queryStringParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? QueryStringParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleActionsRouteConfigurationOverrideCaching), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideCaching")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideCaching
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#behaviour CdnFrontdoorRule#behaviour}.</summary>
            [JsiiProperty(name: "behaviour", typeJson: "{\"primitive\":\"string\"}")]
            public string Behaviour
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#compression_enabled CdnFrontdoorRule#compression_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compressionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CompressionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#duration CdnFrontdoorRule#duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#query_string_behaviour CdnFrontdoorRule#query_string_behaviour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryStringBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryStringBehaviour
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_rule#query_string_parameters CdnFrontdoorRule#query_string_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryStringParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? QueryStringParameters
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
