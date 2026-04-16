using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContact), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContact")]
    public interface IDomainRegistrationOwnerContact
    {
        /// <summary>Primary address line for the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#address_line_1 DomainRegistration#address_line_1}
        /// </remarks>
        [JsiiProperty(name: "addressLine1", typeJson: "{\"primitive\":\"string\"}")]
        string AddressLine1
        {
            get;
        }

        /// <summary>City of the contact's address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#city DomainRegistration#city}
        /// </remarks>
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        string City
        {
            get;
        }

        /// <summary>Company identification code (e.g., SIREN/SIRET in France) for the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#company_identification_code DomainRegistration#company_identification_code}
        /// </remarks>
        [JsiiProperty(name: "companyIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
        string CompanyIdentificationCode
        {
            get;
        }

        /// <summary>Country code of the contact's address (ISO format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#country DomainRegistration#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        string Country
        {
            get;
        }

        /// <summary>Primary email address of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#email DomainRegistration#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        /// <summary>First name of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#firstname DomainRegistration#firstname}
        /// </remarks>
        [JsiiProperty(name: "firstname", typeJson: "{\"primitive\":\"string\"}")]
        string Firstname
        {
            get;
        }

        /// <summary>Last name of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#lastname DomainRegistration#lastname}
        /// </remarks>
        [JsiiProperty(name: "lastname", typeJson: "{\"primitive\":\"string\"}")]
        string Lastname
        {
            get;
        }

        /// <summary>Legal form of the contact (e.g., 'individual' or 'organization').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#legal_form DomainRegistration#legal_form}
        /// </remarks>
        [JsiiProperty(name: "legalForm", typeJson: "{\"primitive\":\"string\"}")]
        string LegalForm
        {
            get;
        }

        /// <summary>Primary phone number of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#phone_number DomainRegistration#phone_number}
        /// </remarks>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        string PhoneNumber
        {
            get;
        }

        /// <summary>VAT identification code of the contact, if applicable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#vat_identification_code DomainRegistration#vat_identification_code}
        /// </remarks>
        [JsiiProperty(name: "vatIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
        string VatIdentificationCode
        {
            get;
        }

        /// <summary>Postal code of the contact's address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#zip DomainRegistration#zip}
        /// </remarks>
        [JsiiProperty(name: "zip", typeJson: "{\"primitive\":\"string\"}")]
        string Zip
        {
            get;
        }

        /// <summary>Secondary address line for the contact (optional).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#address_line_2 DomainRegistration#address_line_2}
        /// </remarks>
        [JsiiProperty(name: "addressLine2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AddressLine2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the company associated with the contact (if applicable).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#company_name DomainRegistration#company_name}
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

        /// <summary>Alternative email address for the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#email_alt DomainRegistration#email_alt}
        /// </remarks>
        [JsiiProperty(name: "emailAlt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailAlt
        {
            get
            {
                return null;
            }
        }

        /// <summary>extension_eu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_eu DomainRegistration#extension_eu}
        /// </remarks>
        [JsiiProperty(name: "extensionEu", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu? ExtensionEu
        {
            get
            {
                return null;
            }
        }

        /// <summary>extension_fr block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_fr DomainRegistration#extension_fr}
        /// </remarks>
        [JsiiProperty(name: "extensionFr", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr? ExtensionFr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Extension details specific to Dutch domain registrations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_nl DomainRegistration#extension_nl}
        /// </remarks>
        [JsiiProperty(name: "extensionNl", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExtensionNl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Fax number for the contact (if available).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#fax_number DomainRegistration#fax_number}
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

        /// <summary>Preferred language of the contact (e.g., 'en_US', 'fr_FR').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#lang DomainRegistration#lang}
        /// </remarks>
        [JsiiProperty(name: "lang", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lang
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the contact is used for resale purposes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#resale DomainRegistration#resale}
        /// </remarks>
        [JsiiProperty(name: "resale", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Resale
        {
            get
            {
                return null;
            }
        }

        /// <summary>State or region of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#state DomainRegistration#state}
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

        /// <summary>Indicates whether the contact has opted into WHOIS publishing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#whois_opt_in DomainRegistration#whois_opt_in}
        /// </remarks>
        [JsiiProperty(name: "whoisOptIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WhoisOptIn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContact), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContact")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContact
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Primary address line for the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#address_line_1 DomainRegistration#address_line_1}
            /// </remarks>
            [JsiiProperty(name: "addressLine1", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressLine1
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>City of the contact's address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#city DomainRegistration#city}
            /// </remarks>
            [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
            public string City
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Company identification code (e.g., SIREN/SIRET in France) for the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#company_identification_code DomainRegistration#company_identification_code}
            /// </remarks>
            [JsiiProperty(name: "companyIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
            public string CompanyIdentificationCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Country code of the contact's address (ISO format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#country DomainRegistration#country}
            /// </remarks>
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
            public string Country
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Primary email address of the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#email DomainRegistration#email}
            /// </remarks>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>First name of the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#firstname DomainRegistration#firstname}
            /// </remarks>
            [JsiiProperty(name: "firstname", typeJson: "{\"primitive\":\"string\"}")]
            public string Firstname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Last name of the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#lastname DomainRegistration#lastname}
            /// </remarks>
            [JsiiProperty(name: "lastname", typeJson: "{\"primitive\":\"string\"}")]
            public string Lastname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Legal form of the contact (e.g., 'individual' or 'organization').</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#legal_form DomainRegistration#legal_form}
            /// </remarks>
            [JsiiProperty(name: "legalForm", typeJson: "{\"primitive\":\"string\"}")]
            public string LegalForm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Primary phone number of the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#phone_number DomainRegistration#phone_number}
            /// </remarks>
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string PhoneNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>VAT identification code of the contact, if applicable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#vat_identification_code DomainRegistration#vat_identification_code}
            /// </remarks>
            [JsiiProperty(name: "vatIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
            public string VatIdentificationCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Postal code of the contact's address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#zip DomainRegistration#zip}
            /// </remarks>
            [JsiiProperty(name: "zip", typeJson: "{\"primitive\":\"string\"}")]
            public string Zip
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Secondary address line for the contact (optional).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#address_line_2 DomainRegistration#address_line_2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addressLine2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AddressLine2
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the company associated with the contact (if applicable).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#company_name DomainRegistration#company_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompanyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Alternative email address for the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#email_alt DomainRegistration#email_alt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailAlt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailAlt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>extension_eu block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_eu DomainRegistration#extension_eu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extensionEu", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu? ExtensionEu
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu?>();
            }

            /// <summary>extension_fr block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_fr DomainRegistration#extension_fr}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extensionFr", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr? ExtensionFr
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr?>();
            }

            /// <summary>Extension details specific to Dutch domain registrations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_nl DomainRegistration#extension_nl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extensionNl", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExtensionNl
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Fax number for the contact (if available).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#fax_number DomainRegistration#fax_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "faxNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FaxNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Preferred language of the contact (e.g., 'en_US', 'fr_FR').</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#lang DomainRegistration#lang}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lang", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lang
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the contact is used for resale purposes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#resale DomainRegistration#resale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resale", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Resale
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>State or region of the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#state DomainRegistration#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates whether the contact has opted into WHOIS publishing.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#whois_opt_in DomainRegistration#whois_opt_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "whoisOptIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WhoisOptIn
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
