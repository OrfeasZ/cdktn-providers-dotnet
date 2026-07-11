using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications")]
    public class ConditionalAccessPolicyConditionsApplications : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_applications ConditionalAccessPolicy#excluded_applications}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedApplications
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#filter ConditionalAccessPolicy#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsFilter\"}", isOptional: true)]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplicationsFilter? Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_applications ConditionalAccessPolicy#included_applications}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedApplications
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_user_actions ConditionalAccessPolicy#included_user_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedUserActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedUserActions
        {
            get;
            set;
        }
    }
}
