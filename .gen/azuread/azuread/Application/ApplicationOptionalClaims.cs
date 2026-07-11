using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiByValue(fqn: "azuread.application.ApplicationOptionalClaims")]
    public class ApplicationOptionalClaims : azuread.Application.IApplicationOptionalClaims
    {
        private object? _accessToken;

        /// <summary>access_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#access_token Application#access_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsAccessToken" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsAccessToken\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AccessToken
        {
            get => _accessToken;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.Application.IApplicationOptionalClaimsAccessToken[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsAccessToken).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accessToken = value;
            }
        }

        private object? _idToken;

        /// <summary>id_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#id_token Application#id_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsIdToken" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idToken", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsIdToken\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IdToken
        {
            get => _idToken;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.Application.IApplicationOptionalClaimsIdToken[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsIdToken).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _idToken = value;
            }
        }

        private object? _saml2Token;

        /// <summary>saml2_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#saml2_token Application#saml2_token}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsSaml2Token" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saml2Token", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsSaml2Token\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Saml2Token
        {
            get => _saml2Token;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.Application.IApplicationOptionalClaimsSaml2Token[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsSaml2Token).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _saml2Token = value;
            }
        }
    }
}
