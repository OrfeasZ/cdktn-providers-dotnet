using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ApplicationRegistration
{
    [JsiiInterface(nativeType: typeof(IApplicationRegistrationConfig), fullyQualifiedName: "azuread.applicationRegistration.ApplicationRegistrationConfig")]
    public interface IApplicationRegistrationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The display name for the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#display_name ApplicationRegistration#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Description of the application as shown to end users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#description ApplicationRegistration#description}
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

        /// <summary>Configures the `groups` claim that the app expects issued in a user or OAuth access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#group_membership_claims ApplicationRegistration#group_membership_claims}
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

        /// <summary>URL of the home page for the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#homepage_url ApplicationRegistration#homepage_url}
        /// </remarks>
        [JsiiProperty(name: "homepageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HomepageUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#id ApplicationRegistration#id}.</summary>
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

        /// <summary>Whether this application can request an access token using OAuth implicit flow.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#implicit_access_token_issuance_enabled ApplicationRegistration#implicit_access_token_issuance_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "implicitAccessTokenIssuanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImplicitAccessTokenIssuanceEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this application can request an ID token using OAuth implicit flow.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#implicit_id_token_issuance_enabled ApplicationRegistration#implicit_id_token_issuance_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "implicitIdTokenIssuanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImplicitIdTokenIssuanceEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the logout page for the application, where the session is cleared for single sign-out.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#logout_url ApplicationRegistration#logout_url}
        /// </remarks>
        [JsiiProperty(name: "logoutUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoutUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the marketing page for the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#marketing_url ApplicationRegistration#marketing_url}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#notes ApplicationRegistration#notes}
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

        /// <summary>URL of the privacy statement for the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#privacy_statement_url ApplicationRegistration#privacy_statement_url}
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

        /// <summary>The access token version expected by this resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#requested_access_token_version ApplicationRegistration#requested_access_token_version}
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

        /// <summary>References application or contact information from a service or asset management database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#service_management_reference ApplicationRegistration#service_management_reference}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#sign_in_audience ApplicationRegistration#sign_in_audience}
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

        /// <summary>URL of the support page for the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#support_url ApplicationRegistration#support_url}
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

        /// <summary>URL of the terms of service statement for the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#terms_of_service_url ApplicationRegistration#terms_of_service_url}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#timeouts ApplicationRegistration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationRegistration.ApplicationRegistrationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ApplicationRegistration.IApplicationRegistrationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationRegistrationConfig), fullyQualifiedName: "azuread.applicationRegistration.ApplicationRegistrationConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.ApplicationRegistration.IApplicationRegistrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The display name for the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#display_name ApplicationRegistration#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Description of the application as shown to end users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#description ApplicationRegistration#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the `groups` claim that the app expects issued in a user or OAuth access token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#group_membership_claims ApplicationRegistration#group_membership_claims}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupMembershipClaims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GroupMembershipClaims
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>URL of the home page for the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#homepage_url ApplicationRegistration#homepage_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "homepageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HomepageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#id ApplicationRegistration#id}.</summary>
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

            /// <summary>Whether this application can request an access token using OAuth implicit flow.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#implicit_access_token_issuance_enabled ApplicationRegistration#implicit_access_token_issuance_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "implicitAccessTokenIssuanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ImplicitAccessTokenIssuanceEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether this application can request an ID token using OAuth implicit flow.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#implicit_id_token_issuance_enabled ApplicationRegistration#implicit_id_token_issuance_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "implicitIdTokenIssuanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ImplicitIdTokenIssuanceEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>URL of the logout page for the application, where the session is cleared for single sign-out.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#logout_url ApplicationRegistration#logout_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logoutUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoutUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL of the marketing page for the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#marketing_url ApplicationRegistration#marketing_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "marketingUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MarketingUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-specified notes relevant for the management of the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#notes ApplicationRegistration#notes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Notes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL of the privacy statement for the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#privacy_statement_url ApplicationRegistration#privacy_statement_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privacyStatementUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivacyStatementUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The access token version expected by this resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#requested_access_token_version ApplicationRegistration#requested_access_token_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestedAccessTokenVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RequestedAccessTokenVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>References application or contact information from a service or asset management database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#service_management_reference ApplicationRegistration#service_management_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceManagementReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceManagementReference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Microsoft account types that are supported for the current application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#sign_in_audience ApplicationRegistration#sign_in_audience}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signInAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignInAudience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL of the support page for the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#support_url ApplicationRegistration#support_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supportUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SupportUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL of the terms of service statement for the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#terms_of_service_url ApplicationRegistration#terms_of_service_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TermsOfServiceUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_registration#timeouts ApplicationRegistration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationRegistration.ApplicationRegistrationTimeouts\"}", isOptional: true)]
            public azuread.ApplicationRegistration.IApplicationRegistrationTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.ApplicationRegistration.IApplicationRegistrationTimeouts?>();
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
