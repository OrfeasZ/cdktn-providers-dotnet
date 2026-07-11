using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipal
{
    [JsiiByValue(fqn: "azuread.servicePrincipal.ServicePrincipalSamlSingleSignOn")]
    public class ServicePrincipalSamlSingleSignOn : azuread.ServicePrincipal.IServicePrincipalSamlSingleSignOn
    {
        /// <summary>The relative URI the service provider would redirect to after completion of the single sign-on flow.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal#relay_state ServicePrincipal#relay_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relayState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelayState
        {
            get;
            set;
        }
    }
}
