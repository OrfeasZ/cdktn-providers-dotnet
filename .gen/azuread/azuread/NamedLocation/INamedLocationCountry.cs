using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.NamedLocation
{
    [JsiiInterface(nativeType: typeof(INamedLocationCountry), fullyQualifiedName: "azuread.namedLocation.NamedLocationCountry")]
    public interface INamedLocationCountry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#countries_and_regions NamedLocation#countries_and_regions}.</summary>
        [JsiiProperty(name: "countriesAndRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CountriesAndRegions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#country_lookup_method NamedLocation#country_lookup_method}.</summary>
        [JsiiProperty(name: "countryLookupMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CountryLookupMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#include_unknown_countries_and_regions NamedLocation#include_unknown_countries_and_regions}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "includeUnknownCountriesAndRegions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeUnknownCountriesAndRegions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INamedLocationCountry), fullyQualifiedName: "azuread.namedLocation.NamedLocationCountry")]
        internal sealed class _Proxy : DeputyBase, azuread.NamedLocation.INamedLocationCountry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#countries_and_regions NamedLocation#countries_and_regions}.</summary>
            [JsiiProperty(name: "countriesAndRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CountriesAndRegions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#country_lookup_method NamedLocation#country_lookup_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "countryLookupMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CountryLookupMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/named_location#include_unknown_countries_and_regions NamedLocation#include_unknown_countries_and_regions}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeUnknownCountriesAndRegions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeUnknownCountriesAndRegions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
