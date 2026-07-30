using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleActionsUrlRewrite), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewrite")]
    public interface ICdnFrontdoorRuleActionsUrlRewrite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#destination_path CdnFrontdoorRule#destination_path}.</summary>
        [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#source_pattern CdnFrontdoorRule#source_pattern}.</summary>
        [JsiiProperty(name: "sourcePattern", typeJson: "{\"primitive\":\"string\"}")]
        string SourcePattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#preserve_unmatched_path_enabled CdnFrontdoorRule#preserve_unmatched_path_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preserveUnmatchedPathEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreserveUnmatchedPathEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleActionsUrlRewrite), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewrite")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRewrite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#destination_path CdnFrontdoorRule#destination_path}.</summary>
            [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#source_pattern CdnFrontdoorRule#source_pattern}.</summary>
            [JsiiProperty(name: "sourcePattern", typeJson: "{\"primitive\":\"string\"}")]
            public string SourcePattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_rule#preserve_unmatched_path_enabled CdnFrontdoorRule#preserve_unmatched_path_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preserveUnmatchedPathEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreserveUnmatchedPathEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
