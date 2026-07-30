using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiByValue(fqn: "azurerm.provider.AzurermProviderFeaturesEnhancedValidation")]
    public class AzurermProviderFeaturesEnhancedValidation : azurerm.Provider.IAzurermProviderFeaturesEnhancedValidation
    {
        private object? _locations;

        /// <summary>Should the AzureRM Provider validate location arguments against the list of supported Azure Locations?</summary>
        /// <remarks>
        /// When enabled, invalid locations are caught at plan time; when disabled, they are caught at apply time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs#locations AzurermProvider#locations}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "locations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Locations
        {
            get => _locations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _locations = value;
            }
        }

        private object? _preflightEnabled;

        /// <summary>Should the AzureRM Provider call the Azure Preflight Validation API at plan time to check the request payload for each Preflight-supported resource is valid.</summary>
        /// <remarks>
        /// Note: requires valid credentials and external Azure API access at plan-time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs#preflight_enabled AzurermProvider#preflight_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preflightEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PreflightEnabled
        {
            get => _preflightEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _preflightEnabled = value;
            }
        }

        /// <summary>The Azure location to use as a fallback when Preflight Validation is enabled and a resource does not specify a location.</summary>
        /// <remarks>
        /// This is typically used for resources that derive their location from a dependency that has not yet been created.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs#preflight_location_fallback AzurermProvider#preflight_location_fallback}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preflightLocationFallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreflightLocationFallback
        {
            get;
            set;
        }

        private object? _resourceProviders;

        /// <summary>Should the AzureRM Provider validate Resource Provider arguments against the list of supported Resource Providers?</summary>
        /// <remarks>
        /// When enabled, invalid resource providers are caught at plan time; when disabled, they are caught at apply time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs#resource_providers AzurermProvider#resource_providers}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceProviders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ResourceProviders
        {
            get => _resourceProviders;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceProviders = value;
            }
        }
    }
}
