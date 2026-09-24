using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadAuthenticationStrengthPolicy
{
    [JsiiByValue(fqn: "azuread.dataAzureadAuthenticationStrengthPolicy.DataAzureadAuthenticationStrengthPolicyTimeouts")]
    public class DataAzureadAuthenticationStrengthPolicyTimeouts : azuread.DataAzureadAuthenticationStrengthPolicy.IDataAzureadAuthenticationStrengthPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/data-sources/authentication_strength_policy#read DataAzureadAuthenticationStrengthPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
