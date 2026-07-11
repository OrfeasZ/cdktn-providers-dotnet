using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsLocations")]
    public class ConditionalAccessPolicyConditionsLocations : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_locations ConditionalAccessPolicy#included_locations}.</summary>
        [JsiiProperty(name: "includedLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] IncludedLocations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_locations ConditionalAccessPolicy#excluded_locations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedLocations
        {
            get;
            set;
        }
    }
}
