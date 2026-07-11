using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.NamedLocation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.namedLocation.NamedLocationCountry")]
    public class NamedLocationCountry : azuread.NamedLocation.INamedLocationCountry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#countries_and_regions NamedLocation#countries_and_regions}.</summary>
        [JsiiProperty(name: "countriesAndRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CountriesAndRegions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#country_lookup_method NamedLocation#country_lookup_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "countryLookupMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CountryLookupMethod
        {
            get;
            set;
        }

        private object? _includeUnknownCountriesAndRegions;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#include_unknown_countries_and_regions NamedLocation#include_unknown_countries_and_regions}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeUnknownCountriesAndRegions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeUnknownCountriesAndRegions
        {
            get => _includeUnknownCountriesAndRegions;
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
                _includeUnknownCountriesAndRegions = value;
            }
        }
    }
}
