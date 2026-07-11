using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevices")]
    public class ConditionalAccessPolicyConditionsDevices : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices
    {
        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#filter ConditionalAccessPolicy#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesFilter\"}", isOptional: true)]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevicesFilter? Filter
        {
            get;
            set;
        }
    }
}
