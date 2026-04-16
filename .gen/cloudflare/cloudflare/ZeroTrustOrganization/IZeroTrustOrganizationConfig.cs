using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustOrganization
{
    [JsiiInterface(nativeType: typeof(IZeroTrustOrganizationConfig), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationConfig")]
    public interface IZeroTrustOrganizationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The Account ID to use for this endpoint. Mutually exclusive with the Zone ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#account_id ZeroTrustOrganization#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>When set to true, users can authenticate via WARP for any application in your organization.</summary>
        /// <remarks>
        /// Application settings will take precedence over this value.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#allow_authenticate_via_warp ZeroTrustOrganization#allow_authenticate_via_warp}
        /// </remarks>
        [JsiiProperty(name: "allowAuthenticateViaWarp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAuthenticateViaWarp
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unique subdomain assigned to your Zero Trust organization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#auth_domain ZeroTrustOrganization#auth_domain}
        /// </remarks>
        [JsiiProperty(name: "authDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>When set to `true`, users skip the identity provider selection step during login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#auto_redirect_to_identity ZeroTrustOrganization#auto_redirect_to_identity}
        /// </remarks>
        [JsiiProperty(name: "autoRedirectToIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoRedirectToIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#custom_pages ZeroTrustOrganization#custom_pages}.</summary>
        [JsiiProperty(name: "customPages", typeJson: "{\"fqn\":\"cloudflare.zeroTrustOrganization.ZeroTrustOrganizationCustomPages\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationCustomPages? CustomPages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines whether to deny all requests to Cloudflare-protected resources that lack an associated Access application.</summary>
        /// <remarks>
        /// If enabled, you must explicitly configure an Access application and policy to allow traffic to your Cloudflare-protected resources. For domains you want to be public across all subdomains, add the domain to the <c>deny_unmatched_requests_exempted_zone_names</c> array.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#deny_unmatched_requests ZeroTrustOrganization#deny_unmatched_requests}
        /// </remarks>
        [JsiiProperty(name: "denyUnmatchedRequests", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DenyUnmatchedRequests
        {
            get
            {
                return null;
            }
        }

        /// <summary>Contains zone names to exempt from the `deny_unmatched_requests` feature.</summary>
        /// <remarks>
        /// Requests to a subdomain in an exempted zone will block unauthenticated traffic by default if there is a configured Access application and policy that matches the request.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#deny_unmatched_requests_exempted_zone_names ZeroTrustOrganization#deny_unmatched_requests_exempted_zone_names}
        /// </remarks>
        [JsiiProperty(name: "denyUnmatchedRequestsExemptedZoneNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DenyUnmatchedRequestsExemptedZoneNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lock all settings as Read-Only in the Dashboard, regardless of user permission.</summary>
        /// <remarks>
        /// Updates may only be made via the API or Terraform for this account when enabled.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#is_ui_read_only ZeroTrustOrganization#is_ui_read_only}
        /// </remarks>
        [JsiiProperty(name: "isUiReadOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsUiReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#login_design ZeroTrustOrganization#login_design}.</summary>
        [JsiiProperty(name: "loginDesign", typeJson: "{\"fqn\":\"cloudflare.zeroTrustOrganization.ZeroTrustOrganizationLoginDesign\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationLoginDesign? LoginDesign
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures multi-factor authentication (MFA) settings for an organization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#mfa_config ZeroTrustOrganization#mfa_config}
        /// </remarks>
        [JsiiProperty(name: "mfaConfig", typeJson: "{\"fqn\":\"cloudflare.zeroTrustOrganization.ZeroTrustOrganizationMfaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationMfaConfig? MfaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if this organization can enforce multi-factor authentication (MFA) requirements at the application and policy level.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#mfa_configuration_allowed ZeroTrustOrganization#mfa_configuration_allowed}
        /// </remarks>
        [JsiiProperty(name: "mfaConfigurationAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MfaConfigurationAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines whether global MFA settings apply to applications by default.</summary>
        /// <remarks>
        /// The organization must have MFA enabled with at least one authentication method and a session duration configured.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#mfa_required_for_all_apps ZeroTrustOrganization#mfa_required_for_all_apps}
        /// </remarks>
        [JsiiProperty(name: "mfaRequiredForAllApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MfaRequiredForAllApps
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of your Zero Trust organization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#name ZeroTrustOrganization#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of time that tokens issued for applications will be valid.</summary>
        /// <remarks>
        /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are: ns, us (or µs), ms, s, m, h.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#session_duration ZeroTrustOrganization#session_duration}
        /// </remarks>
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>A description of the reason why the UI read only field is being toggled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#ui_read_only_toggle_reason ZeroTrustOrganization#ui_read_only_toggle_reason}
        /// </remarks>
        [JsiiProperty(name: "uiReadOnlyToggleReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UiReadOnlyToggleReason
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of time a user seat is inactive before it expires.</summary>
        /// <remarks>
        /// When the user seat exceeds the set time of inactivity, the user is removed as an active seat and no longer counts against your Teams seat count.  Minimum value for this setting is 1 month (730h). Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are: <c>ns</c>, <c>us</c> (or <c>µs</c>), <c>ms</c>, <c>s</c>, <c>m</c>, <c>h</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#user_seat_expiration_inactive_time ZeroTrustOrganization#user_seat_expiration_inactive_time}
        /// </remarks>
        [JsiiProperty(name: "userSeatExpirationInactiveTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserSeatExpirationInactiveTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of time that tokens issued for applications will be valid.</summary>
        /// <remarks>
        /// Must be in the format <c>30m</c> or <c>2h45m</c>. Valid time units are: m, h.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#warp_auth_session_duration ZeroTrustOrganization#warp_auth_session_duration}
        /// </remarks>
        [JsiiProperty(name: "warpAuthSessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarpAuthSessionDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Zone ID to use for this endpoint. Mutually exclusive with the Account ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#zone_id ZeroTrustOrganization#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustOrganizationConfig), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Account ID to use for this endpoint. Mutually exclusive with the Zone ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#account_id ZeroTrustOrganization#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When set to true, users can authenticate via WARP for any application in your organization.</summary>
            /// <remarks>
            /// Application settings will take precedence over this value.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#allow_authenticate_via_warp ZeroTrustOrganization#allow_authenticate_via_warp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowAuthenticateViaWarp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAuthenticateViaWarp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The unique subdomain assigned to your Zero Trust organization.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#auth_domain ZeroTrustOrganization#auth_domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When set to `true`, users skip the identity provider selection step during login.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#auto_redirect_to_identity ZeroTrustOrganization#auto_redirect_to_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRedirectToIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoRedirectToIdentity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#custom_pages ZeroTrustOrganization#custom_pages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customPages", typeJson: "{\"fqn\":\"cloudflare.zeroTrustOrganization.ZeroTrustOrganizationCustomPages\"}", isOptional: true)]
            public cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationCustomPages? CustomPages
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationCustomPages?>();
            }

            /// <summary>Determines whether to deny all requests to Cloudflare-protected resources that lack an associated Access application.</summary>
            /// <remarks>
            /// If enabled, you must explicitly configure an Access application and policy to allow traffic to your Cloudflare-protected resources. For domains you want to be public across all subdomains, add the domain to the <c>deny_unmatched_requests_exempted_zone_names</c> array.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#deny_unmatched_requests ZeroTrustOrganization#deny_unmatched_requests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "denyUnmatchedRequests", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DenyUnmatchedRequests
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Contains zone names to exempt from the `deny_unmatched_requests` feature.</summary>
            /// <remarks>
            /// Requests to a subdomain in an exempted zone will block unauthenticated traffic by default if there is a configured Access application and policy that matches the request.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#deny_unmatched_requests_exempted_zone_names ZeroTrustOrganization#deny_unmatched_requests_exempted_zone_names}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "denyUnmatchedRequestsExemptedZoneNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DenyUnmatchedRequestsExemptedZoneNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Lock all settings as Read-Only in the Dashboard, regardless of user permission.</summary>
            /// <remarks>
            /// Updates may only be made via the API or Terraform for this account when enabled.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#is_ui_read_only ZeroTrustOrganization#is_ui_read_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isUiReadOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsUiReadOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#login_design ZeroTrustOrganization#login_design}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginDesign", typeJson: "{\"fqn\":\"cloudflare.zeroTrustOrganization.ZeroTrustOrganizationLoginDesign\"}", isOptional: true)]
            public cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationLoginDesign? LoginDesign
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationLoginDesign?>();
            }

            /// <summary>Configures multi-factor authentication (MFA) settings for an organization.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#mfa_config ZeroTrustOrganization#mfa_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mfaConfig", typeJson: "{\"fqn\":\"cloudflare.zeroTrustOrganization.ZeroTrustOrganizationMfaConfig\"}", isOptional: true)]
            public cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationMfaConfig? MfaConfig
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationMfaConfig?>();
            }

            /// <summary>Indicates if this organization can enforce multi-factor authentication (MFA) requirements at the application and policy level.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#mfa_configuration_allowed ZeroTrustOrganization#mfa_configuration_allowed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mfaConfigurationAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MfaConfigurationAllowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Determines whether global MFA settings apply to applications by default.</summary>
            /// <remarks>
            /// The organization must have MFA enabled with at least one authentication method and a session duration configured.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#mfa_required_for_all_apps ZeroTrustOrganization#mfa_required_for_all_apps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mfaRequiredForAllApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MfaRequiredForAllApps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The name of your Zero Trust organization.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#name ZeroTrustOrganization#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The amount of time that tokens issued for applications will be valid.</summary>
            /// <remarks>
            /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are: ns, us (or µs), ms, s, m, h.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#session_duration ZeroTrustOrganization#session_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A description of the reason why the UI read only field is being toggled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#ui_read_only_toggle_reason ZeroTrustOrganization#ui_read_only_toggle_reason}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uiReadOnlyToggleReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UiReadOnlyToggleReason
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The amount of time a user seat is inactive before it expires.</summary>
            /// <remarks>
            /// When the user seat exceeds the set time of inactivity, the user is removed as an active seat and no longer counts against your Teams seat count.  Minimum value for this setting is 1 month (730h). Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are: <c>ns</c>, <c>us</c> (or <c>µs</c>), <c>ms</c>, <c>s</c>, <c>m</c>, <c>h</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#user_seat_expiration_inactive_time ZeroTrustOrganization#user_seat_expiration_inactive_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userSeatExpirationInactiveTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserSeatExpirationInactiveTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The amount of time that tokens issued for applications will be valid.</summary>
            /// <remarks>
            /// Must be in the format <c>30m</c> or <c>2h45m</c>. Valid time units are: m, h.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#warp_auth_session_duration ZeroTrustOrganization#warp_auth_session_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "warpAuthSessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarpAuthSessionDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Zone ID to use for this endpoint. Mutually exclusive with the Account ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#zone_id ZeroTrustOrganization#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
