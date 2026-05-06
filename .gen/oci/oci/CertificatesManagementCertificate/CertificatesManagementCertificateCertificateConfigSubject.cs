using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubject")]
    public class CertificatesManagementCertificateCertificateConfigSubject : oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubject
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#common_name CertificatesManagementCertificate#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        public string CommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#country CertificatesManagementCertificate#country}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Country
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#distinguished_name_qualifier CertificatesManagementCertificate#distinguished_name_qualifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distinguishedNameQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DistinguishedNameQualifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#domain_component CertificatesManagementCertificate#domain_component}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainComponent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainComponent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#generation_qualifier CertificatesManagementCertificate#generation_qualifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generationQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GenerationQualifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#given_name CertificatesManagementCertificate#given_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GivenName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#initials CertificatesManagementCertificate#initials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Initials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#locality_name CertificatesManagementCertificate#locality_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localityName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalityName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#organization CertificatesManagementCertificate#organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Organization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#organizational_unit CertificatesManagementCertificate#organizational_unit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationalUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#pseudonym CertificatesManagementCertificate#pseudonym}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pseudonym", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Pseudonym
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#serial_number CertificatesManagementCertificate#serial_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SerialNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#state_or_province_name CertificatesManagementCertificate#state_or_province_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stateOrProvinceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StateOrProvinceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#street CertificatesManagementCertificate#street}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "street", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Street
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#surname CertificatesManagementCertificate#surname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Surname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#title CertificatesManagementCertificate#title}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Title
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#user_id CertificatesManagementCertificate#user_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserId
        {
            get;
            set;
        }
    }
}
