using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiInterface(nativeType: typeof(IApplicationOptionalClaims), fullyQualifiedName: "azuread.application.ApplicationOptionalClaims")]
    public interface IApplicationOptionalClaims
    {
        /// <summary>access_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#access_token Application#access_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsAccessToken" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "accessToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsAccessToken\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccessToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>id_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#id_token Application#id_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsIdToken" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "idToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsIdToken\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>saml2_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#saml2_token Application#saml2_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsSaml2Token" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "saml2Token", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsSaml2Token\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Saml2Token
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationOptionalClaims), fullyQualifiedName: "azuread.application.ApplicationOptionalClaims")]
        internal sealed class _Proxy : DeputyBase, azuread.Application.IApplicationOptionalClaims
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_token block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#access_token Application#access_token}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsAccessToken" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsAccessToken\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AccessToken
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>id_token block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#id_token Application#id_token}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsIdToken" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsIdToken\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdToken
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>saml2_token block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#saml2_token Application#saml2_token}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsSaml2Token" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saml2Token", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsSaml2Token\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Saml2Token
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
