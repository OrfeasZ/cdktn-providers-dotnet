using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplications")]
    public class ConditionalAccessPolicyConditionsClientApplications : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_service_principals ConditionalAccessPolicy#excluded_service_principals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedServicePrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedServicePrincipals
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#filter ConditionalAccessPolicy#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplicationsFilter\"}", isOptional: true)]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplicationsFilter? Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_service_principals ConditionalAccessPolicy#included_service_principals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedServicePrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedServicePrincipals
        {
            get;
            set;
        }
    }
}
