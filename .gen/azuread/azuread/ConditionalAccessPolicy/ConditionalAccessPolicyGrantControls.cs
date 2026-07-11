using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyGrantControls")]
    public class ConditionalAccessPolicyGrantControls : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyGrantControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#operator ConditionalAccessPolicy#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#authentication_strength_policy_id ConditionalAccessPolicy#authentication_strength_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationStrengthPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationStrengthPolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#built_in_controls ConditionalAccessPolicy#built_in_controls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "builtInControls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BuiltInControls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#custom_authentication_factors ConditionalAccessPolicy#custom_authentication_factors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customAuthenticationFactors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomAuthenticationFactors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#terms_of_use ConditionalAccessPolicy#terms_of_use}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "termsOfUse", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TermsOfUse
        {
            get;
            set;
        }
    }
}
