using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiInterface(nativeType: typeof(IApplicationSinglePageApplication), fullyQualifiedName: "azuread.application.ApplicationSinglePageApplication")]
    public interface IApplicationSinglePageApplication
    {
        /// <summary>The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#redirect_uris Application#redirect_uris}
        /// </remarks>
        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RedirectUris
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationSinglePageApplication), fullyQualifiedName: "azuread.application.ApplicationSinglePageApplication")]
        internal sealed class _Proxy : DeputyBase, azuread.Application.IApplicationSinglePageApplication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#redirect_uris Application#redirect_uris}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RedirectUris
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
