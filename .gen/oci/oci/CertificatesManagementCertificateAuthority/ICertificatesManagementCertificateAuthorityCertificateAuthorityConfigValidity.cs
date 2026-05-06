using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity")]
    public interface ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#time_of_validity_not_after CertificatesManagementCertificateAuthority#time_of_validity_not_after}.</summary>
        [JsiiProperty(name: "timeOfValidityNotAfter", typeJson: "{\"primitive\":\"string\"}")]
        string TimeOfValidityNotAfter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#time_of_validity_not_before CertificatesManagementCertificateAuthority#time_of_validity_not_before}.</summary>
        [JsiiProperty(name: "timeOfValidityNotBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeOfValidityNotBefore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity")]
        internal sealed class _Proxy : DeputyBase, oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#time_of_validity_not_after CertificatesManagementCertificateAuthority#time_of_validity_not_after}.</summary>
            [JsiiProperty(name: "timeOfValidityNotAfter", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeOfValidityNotAfter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#time_of_validity_not_before CertificatesManagementCertificateAuthority#time_of_validity_not_before}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeOfValidityNotBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeOfValidityNotBefore
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
