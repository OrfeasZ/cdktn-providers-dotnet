using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSelfRegistrationProfile
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSelfRegistrationProfileConfig), fullyQualifiedName: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileConfig")]
    public interface IIdentityDomainsSelfRegistrationProfileConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#activation_email_required IdentityDomainsSelfRegistrationProfile#activation_email_required}.</summary>
        [JsiiProperty(name: "activationEmailRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ActivationEmailRequired
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#consent_text_present IdentityDomainsSelfRegistrationProfile#consent_text_present}.</summary>
        [JsiiProperty(name: "consentTextPresent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ConsentTextPresent
        {
            get;
        }

        /// <summary>display_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#display_name IdentityDomainsSelfRegistrationProfile#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileDisplayName\"},\"kind\":\"array\"}}]}}")]
        object DisplayName
        {
            get;
        }

        /// <summary>email_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#email_template IdentityDomainsSelfRegistrationProfile#email_template}
        /// </remarks>
        [JsiiProperty(name: "emailTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileEmailTemplate\"}")]
        oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileEmailTemplate EmailTemplate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#idcs_endpoint IdentityDomainsSelfRegistrationProfile#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#name IdentityDomainsSelfRegistrationProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#number_of_days_redirect_url_is_valid IdentityDomainsSelfRegistrationProfile#number_of_days_redirect_url_is_valid}.</summary>
        [JsiiProperty(name: "numberOfDaysRedirectUrlIsValid", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfDaysRedirectUrlIsValid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#redirect_url IdentityDomainsSelfRegistrationProfile#redirect_url}.</summary>
        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RedirectUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#schemas IdentityDomainsSelfRegistrationProfile#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#show_on_login_page IdentityDomainsSelfRegistrationProfile#show_on_login_page}.</summary>
        [JsiiProperty(name: "showOnLoginPage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ShowOnLoginPage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#active IdentityDomainsSelfRegistrationProfile#active}.</summary>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>after_submit_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#after_submit_text IdentityDomainsSelfRegistrationProfile#after_submit_text}
        /// </remarks>
        [JsiiProperty(name: "afterSubmitText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileAfterSubmitText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AfterSubmitText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#allowed_email_domains IdentityDomainsSelfRegistrationProfile#allowed_email_domains}.</summary>
        [JsiiProperty(name: "allowedEmailDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedEmailDomains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#attributes IdentityDomainsSelfRegistrationProfile#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#attribute_sets IdentityDomainsSelfRegistrationProfile#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#authorization IdentityDomainsSelfRegistrationProfile#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>consent_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#consent_text IdentityDomainsSelfRegistrationProfile#consent_text}
        /// </remarks>
        [JsiiProperty(name: "consentText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileConsentText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConsentText
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#default_groups IdentityDomainsSelfRegistrationProfile#default_groups}
        /// </remarks>
        [JsiiProperty(name: "defaultGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileDefaultGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#disallowed_email_domains IdentityDomainsSelfRegistrationProfile#disallowed_email_domains}.</summary>
        [JsiiProperty(name: "disallowedEmailDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DisallowedEmailDomains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#external_id IdentityDomainsSelfRegistrationProfile#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#footer_logo IdentityDomainsSelfRegistrationProfile#footer_logo}.</summary>
        [JsiiProperty(name: "footerLogo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FooterLogo
        {
            get
            {
                return null;
            }
        }

        /// <summary>footer_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#footer_text IdentityDomainsSelfRegistrationProfile#footer_text}
        /// </remarks>
        [JsiiProperty(name: "footerText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileFooterText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FooterText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#header_logo IdentityDomainsSelfRegistrationProfile#header_logo}.</summary>
        [JsiiProperty(name: "headerLogo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeaderLogo
        {
            get
            {
                return null;
            }
        }

        /// <summary>header_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#header_text IdentityDomainsSelfRegistrationProfile#header_text}
        /// </remarks>
        [JsiiProperty(name: "headerText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileHeaderText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HeaderText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#ocid IdentityDomainsSelfRegistrationProfile#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#resource_type_schema_version IdentityDomainsSelfRegistrationProfile#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#tags IdentityDomainsSelfRegistrationProfile#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#timeouts IdentityDomainsSelfRegistrationProfile#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#user_attributes IdentityDomainsSelfRegistrationProfile#user_attributes}
        /// </remarks>
        [JsiiProperty(name: "userAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileUserAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserAttributes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSelfRegistrationProfileConfig), fullyQualifiedName: "oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#activation_email_required IdentityDomainsSelfRegistrationProfile#activation_email_required}.</summary>
            [JsiiProperty(name: "activationEmailRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ActivationEmailRequired
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#consent_text_present IdentityDomainsSelfRegistrationProfile#consent_text_present}.</summary>
            [JsiiProperty(name: "consentTextPresent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ConsentTextPresent
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>display_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#display_name IdentityDomainsSelfRegistrationProfile#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileDisplayName\"},\"kind\":\"array\"}}]}}")]
            public object DisplayName
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>email_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#email_template IdentityDomainsSelfRegistrationProfile#email_template}
            /// </remarks>
            [JsiiProperty(name: "emailTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileEmailTemplate\"}")]
            public oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileEmailTemplate EmailTemplate
            {
                get => GetInstanceProperty<oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileEmailTemplate>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#idcs_endpoint IdentityDomainsSelfRegistrationProfile#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#name IdentityDomainsSelfRegistrationProfile#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#number_of_days_redirect_url_is_valid IdentityDomainsSelfRegistrationProfile#number_of_days_redirect_url_is_valid}.</summary>
            [JsiiProperty(name: "numberOfDaysRedirectUrlIsValid", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfDaysRedirectUrlIsValid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#redirect_url IdentityDomainsSelfRegistrationProfile#redirect_url}.</summary>
            [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RedirectUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#schemas IdentityDomainsSelfRegistrationProfile#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#show_on_login_page IdentityDomainsSelfRegistrationProfile#show_on_login_page}.</summary>
            [JsiiProperty(name: "showOnLoginPage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ShowOnLoginPage
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#active IdentityDomainsSelfRegistrationProfile#active}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>after_submit_text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#after_submit_text IdentityDomainsSelfRegistrationProfile#after_submit_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "afterSubmitText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileAfterSubmitText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AfterSubmitText
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#allowed_email_domains IdentityDomainsSelfRegistrationProfile#allowed_email_domains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedEmailDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedEmailDomains
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#attributes IdentityDomainsSelfRegistrationProfile#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#attribute_sets IdentityDomainsSelfRegistrationProfile#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#authorization IdentityDomainsSelfRegistrationProfile#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>consent_text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#consent_text IdentityDomainsSelfRegistrationProfile#consent_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consentText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileConsentText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConsentText
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#default_groups IdentityDomainsSelfRegistrationProfile#default_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileDefaultGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefaultGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#disallowed_email_domains IdentityDomainsSelfRegistrationProfile#disallowed_email_domains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disallowedEmailDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DisallowedEmailDomains
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#external_id IdentityDomainsSelfRegistrationProfile#external_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#footer_logo IdentityDomainsSelfRegistrationProfile#footer_logo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "footerLogo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FooterLogo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>footer_text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#footer_text IdentityDomainsSelfRegistrationProfile#footer_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footerText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileFooterText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FooterText
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#header_logo IdentityDomainsSelfRegistrationProfile#header_logo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headerLogo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderLogo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>header_text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#header_text IdentityDomainsSelfRegistrationProfile#header_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileHeaderText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HeaderText
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#ocid IdentityDomainsSelfRegistrationProfile#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#resource_type_schema_version IdentityDomainsSelfRegistrationProfile#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#tags IdentityDomainsSelfRegistrationProfile#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#timeouts IdentityDomainsSelfRegistrationProfile#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsSelfRegistrationProfile.IIdentityDomainsSelfRegistrationProfileTimeouts?>();
            }

            /// <summary>user_attributes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_self_registration_profile#user_attributes IdentityDomainsSelfRegistrationProfile#user_attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSelfRegistrationProfile.IdentityDomainsSelfRegistrationProfileUserAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UserAttributes
            {
                get => GetInstanceProperty<object?>();
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
