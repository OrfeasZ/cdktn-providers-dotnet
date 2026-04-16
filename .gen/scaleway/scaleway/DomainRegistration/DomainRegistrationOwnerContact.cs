using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContact")]
    public class DomainRegistrationOwnerContact : scaleway.DomainRegistration.IDomainRegistrationOwnerContact
    {
        /// <summary>Primary address line for the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#address_line_1 DomainRegistration#address_line_1}
        /// </remarks>
        [JsiiProperty(name: "addressLine1", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressLine1
        {
            get;
            set;
        }

        /// <summary>City of the contact's address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#city DomainRegistration#city}
        /// </remarks>
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public string City
        {
            get;
            set;
        }

        /// <summary>Company identification code (e.g., SIREN/SIRET in France) for the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#company_identification_code DomainRegistration#company_identification_code}
        /// </remarks>
        [JsiiProperty(name: "companyIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
        public string CompanyIdentificationCode
        {
            get;
            set;
        }

        /// <summary>Country code of the contact's address (ISO format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#country DomainRegistration#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public string Country
        {
            get;
            set;
        }

        /// <summary>Primary email address of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#email DomainRegistration#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>First name of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#firstname DomainRegistration#firstname}
        /// </remarks>
        [JsiiProperty(name: "firstname", typeJson: "{\"primitive\":\"string\"}")]
        public string Firstname
        {
            get;
            set;
        }

        /// <summary>Last name of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#lastname DomainRegistration#lastname}
        /// </remarks>
        [JsiiProperty(name: "lastname", typeJson: "{\"primitive\":\"string\"}")]
        public string Lastname
        {
            get;
            set;
        }

        /// <summary>Legal form of the contact (e.g., 'individual' or 'organization').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#legal_form DomainRegistration#legal_form}
        /// </remarks>
        [JsiiProperty(name: "legalForm", typeJson: "{\"primitive\":\"string\"}")]
        public string LegalForm
        {
            get;
            set;
        }

        /// <summary>Primary phone number of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#phone_number DomainRegistration#phone_number}
        /// </remarks>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>VAT identification code of the contact, if applicable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#vat_identification_code DomainRegistration#vat_identification_code}
        /// </remarks>
        [JsiiProperty(name: "vatIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
        public string VatIdentificationCode
        {
            get;
            set;
        }

        /// <summary>Postal code of the contact's address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#zip DomainRegistration#zip}
        /// </remarks>
        [JsiiProperty(name: "zip", typeJson: "{\"primitive\":\"string\"}")]
        public string Zip
        {
            get;
            set;
        }

        /// <summary>Secondary address line for the contact (optional).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#address_line_2 DomainRegistration#address_line_2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressLine2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AddressLine2
        {
            get;
            set;
        }

        /// <summary>Name of the company associated with the contact (if applicable).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#company_name DomainRegistration#company_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompanyName
        {
            get;
            set;
        }

        /// <summary>Alternative email address for the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#email_alt DomainRegistration#email_alt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailAlt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailAlt
        {
            get;
            set;
        }

        /// <summary>extension_eu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_eu DomainRegistration#extension_eu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extensionEu", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu\"}", isOptional: true)]
        public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu? ExtensionEu
        {
            get;
            set;
        }

        /// <summary>extension_fr block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_fr DomainRegistration#extension_fr}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extensionFr", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr\"}", isOptional: true)]
        public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr? ExtensionFr
        {
            get;
            set;
        }

        /// <summary>Extension details specific to Dutch domain registrations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#extension_nl DomainRegistration#extension_nl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extensionNl", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExtensionNl
        {
            get;
            set;
        }

        /// <summary>Fax number for the contact (if available).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#fax_number DomainRegistration#fax_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "faxNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FaxNumber
        {
            get;
            set;
        }

        /// <summary>Preferred language of the contact (e.g., 'en_US', 'fr_FR').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#lang DomainRegistration#lang}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lang", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Lang
        {
            get;
            set;
        }

        private object? _resale;

        /// <summary>Indicates if the contact is used for resale purposes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#resale DomainRegistration#resale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resale", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Resale
        {
            get => _resale;
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
                _resale = value;
            }
        }

        /// <summary>State or region of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#state DomainRegistration#state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }

        private object? _whoisOptIn;

        /// <summary>Indicates whether the contact has opted into WHOIS publishing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#whois_opt_in DomainRegistration#whois_opt_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "whoisOptIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? WhoisOptIn
        {
            get => _whoisOptIn;
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
                _whoisOptIn = value;
            }
        }
    }
}
