using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityRules), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRules")]
    public interface ICertificatesManagementCertificateAuthorityCertificateAuthorityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#rule_type CertificatesManagementCertificateAuthority#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        string RuleType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#certificate_authority_max_validity_duration CertificatesManagementCertificateAuthority#certificate_authority_max_validity_duration}.</summary>
        [JsiiProperty(name: "certificateAuthorityMaxValidityDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateAuthorityMaxValidityDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#leaf_certificate_max_validity_duration CertificatesManagementCertificateAuthority#leaf_certificate_max_validity_duration}.</summary>
        [JsiiProperty(name: "leafCertificateMaxValidityDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LeafCertificateMaxValidityDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityRules), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRules")]
        internal sealed class _Proxy : DeputyBase, oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#rule_type CertificatesManagementCertificateAuthority#rule_type}.</summary>
            [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#certificate_authority_max_validity_duration CertificatesManagementCertificateAuthority#certificate_authority_max_validity_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthorityMaxValidityDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateAuthorityMaxValidityDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#leaf_certificate_max_validity_duration CertificatesManagementCertificateAuthority#leaf_certificate_max_validity_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "leafCertificateMaxValidityDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LeafCertificateMaxValidityDuration
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
