using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants")]
    public class ConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#membership_kind ConditionalAccessPolicy#membership_kind}.</summary>
        [JsiiProperty(name: "membershipKind", typeJson: "{\"primitive\":\"string\"}")]
        public string MembershipKind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#members ConditionalAccessPolicy#members}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "members", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Members
        {
            get;
            set;
        }
    }
}
