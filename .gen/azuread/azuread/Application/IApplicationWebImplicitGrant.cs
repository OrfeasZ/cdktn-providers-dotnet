using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiInterface(nativeType: typeof(IApplicationWebImplicitGrant), fullyQualifiedName: "azuread.application.ApplicationWebImplicitGrant")]
    public interface IApplicationWebImplicitGrant
    {
        /// <summary>Whether this web application can request an access token using OAuth 2.0 implicit flow.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#access_token_issuance_enabled Application#access_token_issuance_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "accessTokenIssuanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccessTokenIssuanceEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this web application can request an ID token using OAuth 2.0 implicit flow.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#id_token_issuance_enabled Application#id_token_issuance_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "idTokenIssuanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdTokenIssuanceEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationWebImplicitGrant), fullyQualifiedName: "azuread.application.ApplicationWebImplicitGrant")]
        internal sealed class _Proxy : DeputyBase, azuread.Application.IApplicationWebImplicitGrant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether this web application can request an access token using OAuth 2.0 implicit flow.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#access_token_issuance_enabled Application#access_token_issuance_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessTokenIssuanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AccessTokenIssuanceEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether this web application can request an ID token using OAuth 2.0 implicit flow.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#id_token_issuance_enabled Application#id_token_issuance_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idTokenIssuanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IdTokenIssuanceEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
