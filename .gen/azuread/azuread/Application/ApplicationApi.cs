using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiByValue(fqn: "azuread.application.ApplicationApi")]
    public class ApplicationApi : azuread.Application.IApplicationApi
    {
        /// <summary>Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#known_client_applications Application#known_client_applications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knownClientApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? KnownClientApplications
        {
            get;
            set;
        }

        private object? _mappedClaimsEnabled;

        /// <summary>Allows an application to use claims mapping without specifying a custom signing key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#mapped_claims_enabled Application#mapped_claims_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mappedClaimsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MappedClaimsEnabled
        {
            get => _mappedClaimsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mappedClaimsEnabled = value;
            }
        }

        private object? _oauth2PermissionScope;

        /// <summary>oauth2_permission_scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#oauth2_permission_scope Application#oauth2_permission_scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationApiOauth2PermissionScope" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth2PermissionScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationApiOauth2PermissionScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Oauth2PermissionScope
        {
            get => _oauth2PermissionScope;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.Application.IApplicationApiOauth2PermissionScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationApiOauth2PermissionScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _oauth2PermissionScope = value;
            }
        }

        /// <summary>The access token version expected by this resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#requested_access_token_version Application#requested_access_token_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestedAccessTokenVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RequestedAccessTokenVersion
        {
            get;
            set;
        }
    }
}
