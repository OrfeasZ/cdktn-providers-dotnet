using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContactExtensionNl), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionNl")]
    public interface IDomainRegistrationOwnerContactExtensionNl
    {
        /// <summary>SIDN legal form for .nl domains (e.g. limited_company, natural_person). Distinct from the contact-level legal_form.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/domain_registration#legal_form DomainRegistration#legal_form}
        /// </remarks>
        [JsiiProperty(name: "legalForm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LegalForm
        {
            get
            {
                return null;
            }
        }

        /// <summary>KvK (Chamber of Commerce) or other registry registration number for the SIDN legal form.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/domain_registration#legal_form_registration_number DomainRegistration#legal_form_registration_number}
        /// </remarks>
        [JsiiProperty(name: "legalFormRegistrationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LegalFormRegistrationNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContactExtensionNl), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionNl")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionNl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>SIDN legal form for .nl domains (e.g. limited_company, natural_person). Distinct from the contact-level legal_form.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/domain_registration#legal_form DomainRegistration#legal_form}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "legalForm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LegalForm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>KvK (Chamber of Commerce) or other registry registration number for the SIDN legal form.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.93.0/docs/resources/domain_registration#legal_form_registration_number DomainRegistration#legal_form_registration_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "legalFormRegistrationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LegalFormRegistrationNumber
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
