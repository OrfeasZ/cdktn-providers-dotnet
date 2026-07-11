using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiInterface(nativeType: typeof(IApplicationApi), fullyQualifiedName: "azuread.application.ApplicationApi")]
    public interface IApplicationApi
    {
        /// <summary>Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#known_client_applications Application#known_client_applications}
        /// </remarks>
        [JsiiProperty(name: "knownClientApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? KnownClientApplications
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows an application to use claims mapping without specifying a custom signing key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#mapped_claims_enabled Application#mapped_claims_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "mappedClaimsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MappedClaimsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth2_permission_scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#oauth2_permission_scope Application#oauth2_permission_scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationApiOauth2PermissionScope" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "oauth2PermissionScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationApiOauth2PermissionScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Oauth2PermissionScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>The access token version expected by this resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#requested_access_token_version Application#requested_access_token_version}
        /// </remarks>
        [JsiiProperty(name: "requestedAccessTokenVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RequestedAccessTokenVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationApi), fullyQualifiedName: "azuread.application.ApplicationApi")]
        internal sealed class _Proxy : DeputyBase, azuread.Application.IApplicationApi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#known_client_applications Application#known_client_applications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knownClientApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? KnownClientApplications
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Allows an application to use claims mapping without specifying a custom signing key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#mapped_claims_enabled Application#mapped_claims_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mappedClaimsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MappedClaimsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>oauth2_permission_scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#oauth2_permission_scope Application#oauth2_permission_scope}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationApiOauth2PermissionScope" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth2PermissionScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationApiOauth2PermissionScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Oauth2PermissionScope
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The access token version expected by this resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#requested_access_token_version Application#requested_access_token_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestedAccessTokenVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RequestedAccessTokenVersion
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
