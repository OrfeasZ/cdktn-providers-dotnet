using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails")]
    public interface ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/certificates_management_certificate_authority#action_type CertificatesManagementCertificateAuthority#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/certificates_management_certificate_authority#certificate_pem CertificatesManagementCertificateAuthority#certificate_pem}.</summary>
        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificatePem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/certificates_management_certificate_authority#action_type CertificatesManagementCertificateAuthority#action_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/certificates_management_certificate_authority#certificate_pem CertificatesManagementCertificateAuthority#certificate_pem}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificatePem
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
