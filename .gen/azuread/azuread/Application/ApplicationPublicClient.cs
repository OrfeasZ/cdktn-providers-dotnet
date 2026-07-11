using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiByValue(fqn: "azuread.application.ApplicationPublicClient")]
    public class ApplicationPublicClient : azuread.Application.IApplicationPublicClient
    {
        /// <summary>The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#redirect_uris Application#redirect_uris}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RedirectUris
        {
            get;
            set;
        }
    }
}
