using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AuthenticationStrengthPolicyX509CombinationConfiguration
{
    [JsiiByValue(fqn: "azuread.authenticationStrengthPolicyX509CombinationConfiguration.AuthenticationStrengthPolicyX509CombinationConfigurationTimeouts")]
    public class AuthenticationStrengthPolicyX509CombinationConfigurationTimeouts : azuread.AuthenticationStrengthPolicyX509CombinationConfiguration.IAuthenticationStrengthPolicyX509CombinationConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#create AuthenticationStrengthPolicyX509CombinationConfiguration#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#delete AuthenticationStrengthPolicyX509CombinationConfiguration#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#read AuthenticationStrengthPolicyX509CombinationConfiguration#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#update AuthenticationStrengthPolicyX509CombinationConfiguration#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
