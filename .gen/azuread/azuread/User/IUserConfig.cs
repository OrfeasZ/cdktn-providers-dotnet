using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.User
{
    [JsiiInterface(nativeType: typeof(IUserConfig), fullyQualifiedName: "azuread.user.UserConfig")]
    public interface IUserConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The name to display in the address book for the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#display_name User#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The user principal name (UPN) of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#user_principal_name User#user_principal_name}
        /// </remarks>
        [JsiiProperty(name: "userPrincipalName", typeJson: "{\"primitive\":\"string\"}")]
        string UserPrincipalName
        {
            get;
        }

        /// <summary>Whether or not the account should be enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#account_enabled User#account_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "accountEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccountEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The age group of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#age_group User#age_group}
        /// </remarks>
        [JsiiProperty(name: "ageGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgeGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>The telephone numbers for the user.</summary>
        /// <remarks>
        /// Only one number can be set for this property. Read-only for users synced with Azure AD Connect
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#business_phones User#business_phones}
        /// </remarks>
        [JsiiProperty(name: "businessPhones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BusinessPhones
        {
            get
            {
                return null;
            }
        }

        /// <summary>The city in which the user is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#city User#city}
        /// </remarks>
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? City
        {
            get
            {
                return null;
            }
        }

        /// <summary>The company name which the user is associated.</summary>
        /// <remarks>
        /// This property can be useful for describing the company that an external user comes from
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#company_name User#company_name}
        /// </remarks>
        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompanyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether consent has been obtained for minors.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#consent_provided_for_minor User#consent_provided_for_minor}
        /// </remarks>
        [JsiiProperty(name: "consentProvidedForMinor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsentProvidedForMinor
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cost center associated with the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#cost_center User#cost_center}
        /// </remarks>
        [JsiiProperty(name: "costCenter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CostCenter
        {
            get
            {
                return null;
            }
        }

        /// <summary>The country/region in which the user is located, e.g. `US` or `UK`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#country User#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name for the department in which the user works.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#department User#department}
        /// </remarks>
        [JsiiProperty(name: "department", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Department
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the users password is exempt from expiring.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#disable_password_expiration User#disable_password_expiration}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disablePasswordExpiration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisablePasswordExpiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the user is allowed weaker passwords than the default policy to be specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#disable_strong_password User#disable_strong_password}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disableStrongPassword", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableStrongPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the division in which the user works.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#division User#division}
        /// </remarks>
        [JsiiProperty(name: "division", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Division
        {
            get
            {
                return null;
            }
        }

        /// <summary>The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#employee_hire_date User#employee_hire_date}
        /// </remarks>
        [JsiiProperty(name: "employeeHireDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmployeeHireDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The employee identifier assigned to the user by the organisation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#employee_id User#employee_id}
        /// </remarks>
        [JsiiProperty(name: "employeeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmployeeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#employee_type User#employee_type}
        /// </remarks>
        [JsiiProperty(name: "employeeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmployeeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The fax number of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#fax_number User#fax_number}
        /// </remarks>
        [JsiiProperty(name: "faxNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FaxNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the user is forced to change the password during the next sign-in.</summary>
        /// <remarks>
        /// Only takes effect when also changing the password
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#force_password_change User#force_password_change}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "forcePasswordChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForcePasswordChange
        {
            get
            {
                return null;
            }
        }

        /// <summary>The given name (first name) of the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#given_name User#given_name}
        /// </remarks>
        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GivenName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#id User#id}.</summary>
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

        /// <summary>The user’s job title.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#job_title User#job_title}
        /// </remarks>
        [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobTitle
        {
            get
            {
                return null;
            }
        }

        /// <summary>The SMTP address for the user. Cannot be unset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#mail User#mail}
        /// </remarks>
        [JsiiProperty(name: "mail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mail
        {
            get
            {
                return null;
            }
        }

        /// <summary>The mail alias for the user. Defaults to the user name part of the user principal name (UPN).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#mail_nickname User#mail_nickname}
        /// </remarks>
        [JsiiProperty(name: "mailNickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MailNickname
        {
            get
            {
                return null;
            }
        }

        /// <summary>The object ID of the user's manager.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#manager_id User#manager_id}
        /// </remarks>
        [JsiiProperty(name: "managerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The primary cellular telephone number for the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#mobile_phone User#mobile_phone}
        /// </remarks>
        [JsiiProperty(name: "mobilePhone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MobilePhone
        {
            get
            {
                return null;
            }
        }

        /// <summary>The office location in the user's place of business.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#office_location User#office_location}
        /// </remarks>
        [JsiiProperty(name: "officeLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OfficeLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>The value used to associate an on-premise Active Directory user account with their Azure AD user object.</summary>
        /// <remarks>
        /// This must be specified if you are using a federated domain for the user's <c>user_principal_name</c> property when creating a new user account
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#onpremises_immutable_id User#onpremises_immutable_id}
        /// </remarks>
        [JsiiProperty(name: "onpremisesImmutableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnpremisesImmutableId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional email addresses for the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#other_mails User#other_mails}
        /// </remarks>
        [JsiiProperty(name: "otherMails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OtherMails
        {
            get
            {
                return null;
            }
        }

        /// <summary>The password for the user.</summary>
        /// <remarks>
        /// The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#password User#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>The postal code for the user's postal address.</summary>
        /// <remarks>
        /// The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#postal_code User#postal_code}
        /// </remarks>
        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostalCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>The user's preferred language, in ISO 639-1 notation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#preferred_language User#preferred_language}
        /// </remarks>
        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether or not the Outlook global address list should include this user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#show_in_address_list User#show_in_address_list}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "showInAddressList", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShowInAddressList
        {
            get
            {
                return null;
            }
        }

        /// <summary>The state or province in the user's address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#state User#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>The street address of the user's place of business.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#street_address User#street_address}
        /// </remarks>
        [JsiiProperty(name: "streetAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreetAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>The user's surname (family name or last name).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#surname User#surname}
        /// </remarks>
        [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Surname
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#timeouts User#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.user.UserTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.User.IUserTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The usage location of the user.</summary>
        /// <remarks>
        /// Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: <c>NO</c>, <c>JP</c>, and <c>GB</c>. Cannot be reset to null once set
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#usage_location User#usage_location}
        /// </remarks>
        [JsiiProperty(name: "usageLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IUserConfig), fullyQualifiedName: "azuread.user.UserConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.User.IUserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name to display in the address book for the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#display_name User#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The user principal name (UPN) of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#user_principal_name User#user_principal_name}
            /// </remarks>
            [JsiiProperty(name: "userPrincipalName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPrincipalName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether or not the account should be enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#account_enabled User#account_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AccountEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The age group of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#age_group User#age_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ageGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgeGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The telephone numbers for the user.</summary>
            /// <remarks>
            /// Only one number can be set for this property. Read-only for users synced with Azure AD Connect
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#business_phones User#business_phones}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "businessPhones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BusinessPhones
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The city in which the user is located.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#city User#city}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? City
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The company name which the user is associated.</summary>
            /// <remarks>
            /// This property can be useful for describing the company that an external user comes from
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#company_name User#company_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompanyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether consent has been obtained for minors.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#consent_provided_for_minor User#consent_provided_for_minor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consentProvidedForMinor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsentProvidedForMinor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The cost center associated with the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#cost_center User#cost_center}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCenter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CostCenter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The country/region in which the user is located, e.g. `US` or `UK`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#country User#country}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name for the department in which the user works.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#department User#department}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "department", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Department
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the users password is exempt from expiring.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#disable_password_expiration User#disable_password_expiration}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disablePasswordExpiration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisablePasswordExpiration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the user is allowed weaker passwords than the default policy to be specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#disable_strong_password User#disable_strong_password}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableStrongPassword", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableStrongPassword
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The name of the division in which the user works.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#division User#division}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "division", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Division
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#employee_hire_date User#employee_hire_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "employeeHireDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmployeeHireDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The employee identifier assigned to the user by the organisation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#employee_id User#employee_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "employeeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmployeeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#employee_type User#employee_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "employeeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmployeeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The fax number of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#fax_number User#fax_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "faxNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FaxNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the user is forced to change the password during the next sign-in.</summary>
            /// <remarks>
            /// Only takes effect when also changing the password
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#force_password_change User#force_password_change}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forcePasswordChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForcePasswordChange
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The given name (first name) of the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#given_name User#given_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GivenName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#id User#id}.</summary>
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

            /// <summary>The user’s job title.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#job_title User#job_title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobTitle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The SMTP address for the user. Cannot be unset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#mail User#mail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The mail alias for the user. Defaults to the user name part of the user principal name (UPN).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#mail_nickname User#mail_nickname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mailNickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MailNickname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The object ID of the user's manager.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#manager_id User#manager_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The primary cellular telephone number for the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#mobile_phone User#mobile_phone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mobilePhone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MobilePhone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The office location in the user's place of business.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#office_location User#office_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "officeLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OfficeLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The value used to associate an on-premise Active Directory user account with their Azure AD user object.</summary>
            /// <remarks>
            /// This must be specified if you are using a federated domain for the user's <c>user_principal_name</c> property when creating a new user account
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#onpremises_immutable_id User#onpremises_immutable_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onpremisesImmutableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnpremisesImmutableId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Additional email addresses for the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#other_mails User#other_mails}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "otherMails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OtherMails
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The password for the user.</summary>
            /// <remarks>
            /// The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#password User#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The postal code for the user's postal address.</summary>
            /// <remarks>
            /// The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#postal_code User#postal_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostalCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The user's preferred language, in ISO 639-1 notation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#preferred_language User#preferred_language}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether or not the Outlook global address list should include this user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#show_in_address_list User#show_in_address_list}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "showInAddressList", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShowInAddressList
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The state or province in the user's address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#state User#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The street address of the user's place of business.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#street_address User#street_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "streetAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreetAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The user's surname (family name or last name).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#surname User#surname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Surname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#timeouts User#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.user.UserTimeouts\"}", isOptional: true)]
            public azuread.User.IUserTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.User.IUserTimeouts?>();
            }

            /// <summary>The usage location of the user.</summary>
            /// <remarks>
            /// Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: <c>NO</c>, <c>JP</c>, and <c>GB</c>. Cannot be reset to null once set
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/user#usage_location User#usage_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usageLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageLocation
            {
                get => GetInstanceProperty<string?>();
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
