using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesEnhancedValidation), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesEnhancedValidation")]
    public interface IAzurermProviderFeaturesEnhancedValidation
    {
        /// <summary>Should the AzureRM Provider validate location arguments against the list of supported Azure Locations?</summary>
        /// <remarks>
        /// When enabled, invalid locations are caught at plan time; when disabled, they are caught at apply time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs#locations AzurermProvider#locations}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "locations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Locations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the AzureRM Provider call the Azure Preflight Validation API at plan time to check the request payload for each Preflight-supported resource is valid.</summary>
        /// <remarks>
        /// Note: requires valid credentials and external Azure API access at plan-time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs#preflight_enabled AzurermProvider#preflight_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preflightEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreflightEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Azure location to use as a fallback when Preflight Validation is enabled and a resource does not specify a location.</summary>
        /// <remarks>
        /// This is typically used for resources that derive their location from a dependency that has not yet been created.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs#preflight_location_fallback AzurermProvider#preflight_location_fallback}
        /// </remarks>
        [JsiiProperty(name: "preflightLocationFallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreflightLocationFallback
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the AzureRM Provider validate Resource Provider arguments against the list of supported Resource Providers?</summary>
        /// <remarks>
        /// When enabled, invalid resource providers are caught at plan time; when disabled, they are caught at apply time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs#resource_providers AzurermProvider#resource_providers}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "resourceProviders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceProviders
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesEnhancedValidation), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesEnhancedValidation")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesEnhancedValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Should the AzureRM Provider validate location arguments against the list of supported Azure Locations?</summary>
            /// <remarks>
            /// When enabled, invalid locations are caught at plan time; when disabled, they are caught at apply time.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs#locations AzurermProvider#locations}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Locations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should the AzureRM Provider call the Azure Preflight Validation API at plan time to check the request payload for each Preflight-supported resource is valid.</summary>
            /// <remarks>
            /// Note: requires valid credentials and external Azure API access at plan-time.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs#preflight_enabled AzurermProvider#preflight_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preflightEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreflightEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Azure location to use as a fallback when Preflight Validation is enabled and a resource does not specify a location.</summary>
            /// <remarks>
            /// This is typically used for resources that derive their location from a dependency that has not yet been created.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs#preflight_location_fallback AzurermProvider#preflight_location_fallback}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preflightLocationFallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreflightLocationFallback
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should the AzureRM Provider validate Resource Provider arguments against the list of supported Resource Providers?</summary>
            /// <remarks>
            /// When enabled, invalid resource providers are caught at plan time; when disabled, they are caught at apply time.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs#resource_providers AzurermProvider#resource_providers}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceProviders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ResourceProviders
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
