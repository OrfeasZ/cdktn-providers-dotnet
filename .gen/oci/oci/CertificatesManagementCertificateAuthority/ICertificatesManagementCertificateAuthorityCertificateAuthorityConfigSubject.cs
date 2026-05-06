using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject")]
    public interface ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#common_name CertificatesManagementCertificateAuthority#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        string CommonName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#country CertificatesManagementCertificateAuthority#country}.</summary>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#distinguished_name_qualifier CertificatesManagementCertificateAuthority#distinguished_name_qualifier}.</summary>
        [JsiiProperty(name: "distinguishedNameQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DistinguishedNameQualifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#domain_component CertificatesManagementCertificateAuthority#domain_component}.</summary>
        [JsiiProperty(name: "domainComponent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainComponent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#generation_qualifier CertificatesManagementCertificateAuthority#generation_qualifier}.</summary>
        [JsiiProperty(name: "generationQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GenerationQualifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#given_name CertificatesManagementCertificateAuthority#given_name}.</summary>
        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GivenName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#initials CertificatesManagementCertificateAuthority#initials}.</summary>
        [JsiiProperty(name: "initials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Initials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#locality_name CertificatesManagementCertificateAuthority#locality_name}.</summary>
        [JsiiProperty(name: "localityName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalityName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#organization CertificatesManagementCertificateAuthority#organization}.</summary>
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Organization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#organizational_unit CertificatesManagementCertificateAuthority#organizational_unit}.</summary>
        [JsiiProperty(name: "organizationalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationalUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#pseudonym CertificatesManagementCertificateAuthority#pseudonym}.</summary>
        [JsiiProperty(name: "pseudonym", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Pseudonym
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#serial_number CertificatesManagementCertificateAuthority#serial_number}.</summary>
        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SerialNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#state_or_province_name CertificatesManagementCertificateAuthority#state_or_province_name}.</summary>
        [JsiiProperty(name: "stateOrProvinceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StateOrProvinceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#street CertificatesManagementCertificateAuthority#street}.</summary>
        [JsiiProperty(name: "street", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Street
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#surname CertificatesManagementCertificateAuthority#surname}.</summary>
        [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Surname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#title CertificatesManagementCertificateAuthority#title}.</summary>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Title
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#user_id CertificatesManagementCertificateAuthority#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject")]
        internal sealed class _Proxy : DeputyBase, oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#common_name CertificatesManagementCertificateAuthority#common_name}.</summary>
            [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
            public string CommonName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#country CertificatesManagementCertificateAuthority#country}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#distinguished_name_qualifier CertificatesManagementCertificateAuthority#distinguished_name_qualifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "distinguishedNameQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DistinguishedNameQualifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#domain_component CertificatesManagementCertificateAuthority#domain_component}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainComponent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainComponent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#generation_qualifier CertificatesManagementCertificateAuthority#generation_qualifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generationQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GenerationQualifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#given_name CertificatesManagementCertificateAuthority#given_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GivenName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#initials CertificatesManagementCertificateAuthority#initials}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Initials
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#locality_name CertificatesManagementCertificateAuthority#locality_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localityName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalityName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#organization CertificatesManagementCertificateAuthority#organization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Organization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#organizational_unit CertificatesManagementCertificateAuthority#organizational_unit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organizationalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationalUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#pseudonym CertificatesManagementCertificateAuthority#pseudonym}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pseudonym", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Pseudonym
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#serial_number CertificatesManagementCertificateAuthority#serial_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SerialNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#state_or_province_name CertificatesManagementCertificateAuthority#state_or_province_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stateOrProvinceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StateOrProvinceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#street CertificatesManagementCertificateAuthority#street}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "street", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Street
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#surname CertificatesManagementCertificateAuthority#surname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Surname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#title CertificatesManagementCertificateAuthority#title}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Title
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#user_id CertificatesManagementCertificateAuthority#user_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
