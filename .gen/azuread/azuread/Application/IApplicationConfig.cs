using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiInterface(nativeType: typeof(IApplicationConfig), fullyQualifiedName: "azuread.application.ApplicationConfig")]
    public interface IApplicationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The display name for the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#display_name Application#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>api block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#api Application#api}
        /// </remarks>
        [JsiiProperty(name: "api", typeJson: "{\"fqn\":\"azuread.application.ApplicationApi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.Application.IApplicationApi? Api
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#app_role Application#app_role}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationAppRole" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "appRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationAppRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AppRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description of the application as shown to end users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#description Application#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether this application supports device authentication without a user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#device_only_auth_enabled Application#device_only_auth_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deviceOnlyAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeviceOnlyAuthEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether the application is a public client.</summary>
        /// <remarks>
        /// Appropriate for apps using token grant flows that don't use a redirect URI
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#fallback_public_client_enabled Application#fallback_public_client_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "fallbackPublicClientEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FallbackPublicClientEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>feature_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#feature_tags Application#feature_tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationFeatureTags" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "featureTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationFeatureTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FeatureTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#group_membership_claims Application#group_membership_claims}
        /// </remarks>
        [JsiiProperty(name: "groupMembershipClaims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GroupMembershipClaims
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#id Application#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#identifier_uris Application#identifier_uris}
        /// </remarks>
        [JsiiProperty(name: "identifierUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdentifierUris
        {
            get
            {
                return null;
            }
        }

        /// <summary>Base64 encoded logo image in gif, png or jpeg format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#logo_image Application#logo_image}
        /// </remarks>
        [JsiiProperty(name: "logoImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoImage
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the application's marketing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#marketing_url Application#marketing_url}
        /// </remarks>
        [JsiiProperty(name: "marketingUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MarketingUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>User-specified notes relevant for the management of the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#notes Application#notes}
        /// </remarks>
        [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Notes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#oauth2_post_response_required Application#oauth2_post_response_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "oauth2PostResponseRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Oauth2PostResponseRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>optional_claims block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#optional_claims Application#optional_claims}
        /// </remarks>
        [JsiiProperty(name: "optionalClaims", typeJson: "{\"fqn\":\"azuread.application.ApplicationOptionalClaims\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.Application.IApplicationOptionalClaims? OptionalClaims
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of object IDs of principals that will be granted ownership of the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#owners Application#owners}
        /// </remarks>
        [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Owners
        {
            get
            {
                return null;
            }
        }

        /// <summary>password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#password Application#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"azuread.application.ApplicationPassword\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.Application.IApplicationPassword? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>If `true`, will return an error if an existing application is found with the same name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#prevent_duplicate_names Application#prevent_duplicate_names}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preventDuplicateNames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreventDuplicateNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the application's privacy statement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#privacy_statement_url Application#privacy_statement_url}
        /// </remarks>
        [JsiiProperty(name: "privacyStatementUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivacyStatementUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>public_client block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#public_client Application#public_client}
        /// </remarks>
        [JsiiProperty(name: "publicClient", typeJson: "{\"fqn\":\"azuread.application.ApplicationPublicClient\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.Application.IApplicationPublicClient? PublicClient
        {
            get
            {
                return null;
            }
        }

        /// <summary>required_resource_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#required_resource_access Application#required_resource_access}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationRequiredResourceAccess" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requiredResourceAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationRequiredResourceAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequiredResourceAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>References application or service contact information from a Service or Asset Management database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#service_management_reference Application#service_management_reference}
        /// </remarks>
        [JsiiProperty(name: "serviceManagementReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceManagementReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Microsoft account types that are supported for the current application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#sign_in_audience Application#sign_in_audience}
        /// </remarks>
        [JsiiProperty(name: "signInAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignInAudience
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_page_application block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#single_page_application Application#single_page_application}
        /// </remarks>
        [JsiiProperty(name: "singlePageApplication", typeJson: "{\"fqn\":\"azuread.application.ApplicationSinglePageApplication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.Application.IApplicationSinglePageApplication? SinglePageApplication
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the application's support page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#support_url Application#support_url}
        /// </remarks>
        [JsiiProperty(name: "supportUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SupportUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>A set of tags to apply to the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#tags Application#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Unique ID of the application template from which this application is created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#template_id Application#template_id}
        /// </remarks>
        [JsiiProperty(name: "templateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TemplateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the application's terms of service statement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#terms_of_service_url Application#terms_of_service_url}
        /// </remarks>
        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TermsOfServiceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#timeouts Application#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.application.ApplicationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.Application.IApplicationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>web block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#web Application#web}
        /// </remarks>
        [JsiiProperty(name: "web", typeJson: "{\"fqn\":\"azuread.application.ApplicationWeb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.Application.IApplicationWeb? Web
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationConfig), fullyQualifiedName: "azuread.application.ApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.Application.IApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The display name for the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#display_name Application#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>api block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#api Application#api}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "api", typeJson: "{\"fqn\":\"azuread.application.ApplicationApi\"}", isOptional: true)]
            public azuread.Application.IApplicationApi? Api
            {
                get => GetInstanceProperty<azuread.Application.IApplicationApi?>();
            }

            /// <summary>app_role block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#app_role Application#app_role}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationAppRole" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationAppRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AppRole
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Description of the application as shown to end users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#description Application#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies whether this application supports device authentication without a user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#device_only_auth_enabled Application#device_only_auth_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceOnlyAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeviceOnlyAuthEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies whether the application is a public client.</summary>
            /// <remarks>
            /// Appropriate for apps using token grant flows that don't use a redirect URI
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#fallback_public_client_enabled Application#fallback_public_client_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fallbackPublicClientEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FallbackPublicClientEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>feature_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#feature_tags Application#feature_tags}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationFeatureTags" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "featureTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationFeatureTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FeatureTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#group_membership_claims Application#group_membership_claims}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupMembershipClaims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GroupMembershipClaims
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#id Application#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#identifier_uris Application#identifier_uris}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identifierUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdentifierUris
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Base64 encoded logo image in gif, png or jpeg format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#logo_image Application#logo_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logoImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoImage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL of the application's marketing page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#marketing_url Application#marketing_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "marketingUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MarketingUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-specified notes relevant for the management of the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#notes Application#notes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Notes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#oauth2_post_response_required Application#oauth2_post_response_required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth2PostResponseRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Oauth2PostResponseRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>optional_claims block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#optional_claims Application#optional_claims}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "optionalClaims", typeJson: "{\"fqn\":\"azuread.application.ApplicationOptionalClaims\"}", isOptional: true)]
            public azuread.Application.IApplicationOptionalClaims? OptionalClaims
            {
                get => GetInstanceProperty<azuread.Application.IApplicationOptionalClaims?>();
            }

            /// <summary>A list of object IDs of principals that will be granted ownership of the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#owners Application#owners}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Owners
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>password block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#password Application#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"azuread.application.ApplicationPassword\"}", isOptional: true)]
            public azuread.Application.IApplicationPassword? Password
            {
                get => GetInstanceProperty<azuread.Application.IApplicationPassword?>();
            }

            /// <summary>If `true`, will return an error if an existing application is found with the same name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#prevent_duplicate_names Application#prevent_duplicate_names}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preventDuplicateNames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreventDuplicateNames
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>URL of the application's privacy statement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#privacy_statement_url Application#privacy_statement_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privacyStatementUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivacyStatementUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>public_client block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#public_client Application#public_client}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicClient", typeJson: "{\"fqn\":\"azuread.application.ApplicationPublicClient\"}", isOptional: true)]
            public azuread.Application.IApplicationPublicClient? PublicClient
            {
                get => GetInstanceProperty<azuread.Application.IApplicationPublicClient?>();
            }

            /// <summary>required_resource_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#required_resource_access Application#required_resource_access}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationRequiredResourceAccess" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requiredResourceAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationRequiredResourceAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequiredResourceAccess
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>References application or service contact information from a Service or Asset Management database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#service_management_reference Application#service_management_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceManagementReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceManagementReference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Microsoft account types that are supported for the current application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#sign_in_audience Application#sign_in_audience}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signInAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignInAudience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>single_page_application block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#single_page_application Application#single_page_application}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singlePageApplication", typeJson: "{\"fqn\":\"azuread.application.ApplicationSinglePageApplication\"}", isOptional: true)]
            public azuread.Application.IApplicationSinglePageApplication? SinglePageApplication
            {
                get => GetInstanceProperty<azuread.Application.IApplicationSinglePageApplication?>();
            }

            /// <summary>URL of the application's support page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#support_url Application#support_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supportUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SupportUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A set of tags to apply to the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#tags Application#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Unique ID of the application template from which this application is created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#template_id Application#template_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "templateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TemplateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL of the application's terms of service statement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#terms_of_service_url Application#terms_of_service_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TermsOfServiceUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#timeouts Application#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.application.ApplicationTimeouts\"}", isOptional: true)]
            public azuread.Application.IApplicationTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.Application.IApplicationTimeouts?>();
            }

            /// <summary>web block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#web Application#web}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "web", typeJson: "{\"fqn\":\"azuread.application.ApplicationWeb\"}", isOptional: true)]
            public azuread.Application.IApplicationWeb? Web
            {
                get => GetInstanceProperty<azuread.Application.IApplicationWeb?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
