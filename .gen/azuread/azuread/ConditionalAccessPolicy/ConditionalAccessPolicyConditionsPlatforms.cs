using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatforms")]
    public class ConditionalAccessPolicyConditionsPlatforms : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_platforms ConditionalAccessPolicy#included_platforms}.</summary>
        [JsiiProperty(name: "includedPlatforms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] IncludedPlatforms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_platforms ConditionalAccessPolicy#excluded_platforms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedPlatforms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedPlatforms
        {
            get;
            set;
        }
    }
}
