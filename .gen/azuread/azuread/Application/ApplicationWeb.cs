using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiByValue(fqn: "azuread.application.ApplicationWeb")]
    public class ApplicationWeb : azuread.Application.IApplicationWeb
    {
        /// <summary>Home page or landing page of the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#homepage_url Application#homepage_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "homepageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HomepageUrl
        {
            get;
            set;
        }

        /// <summary>implicit_grant block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#implicit_grant Application#implicit_grant}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "implicitGrant", typeJson: "{\"fqn\":\"azuread.application.ApplicationWebImplicitGrant\"}", isOptional: true)]
        public azuread.Application.IApplicationWebImplicitGrant? ImplicitGrant
        {
            get;
            set;
        }

        /// <summary>The URL that will be used by Microsoft's authorization service to sign out a user using front-channel, back-channel or SAML logout protocols.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#logout_url Application#logout_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logoutUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoutUrl
        {
            get;
            set;
        }

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
