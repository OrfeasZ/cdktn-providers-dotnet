using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificate
{
    [JsiiInterface(nativeType: typeof(ICertificatesManagementCertificateCertificateRules), fullyQualifiedName: "oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateRules")]
    public interface ICertificatesManagementCertificateCertificateRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#advance_renewal_period CertificatesManagementCertificate#advance_renewal_period}.</summary>
        [JsiiProperty(name: "advanceRenewalPeriod", typeJson: "{\"primitive\":\"string\"}")]
        string AdvanceRenewalPeriod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#renewal_interval CertificatesManagementCertificate#renewal_interval}.</summary>
        [JsiiProperty(name: "renewalInterval", typeJson: "{\"primitive\":\"string\"}")]
        string RenewalInterval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#rule_type CertificatesManagementCertificate#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        string RuleType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatesManagementCertificateCertificateRules), fullyQualifiedName: "oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateRules")]
        internal sealed class _Proxy : DeputyBase, oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#advance_renewal_period CertificatesManagementCertificate#advance_renewal_period}.</summary>
            [JsiiProperty(name: "advanceRenewalPeriod", typeJson: "{\"primitive\":\"string\"}")]
            public string AdvanceRenewalPeriod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#renewal_interval CertificatesManagementCertificate#renewal_interval}.</summary>
            [JsiiProperty(name: "renewalInterval", typeJson: "{\"primitive\":\"string\"}")]
            public string RenewalInterval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#rule_type CertificatesManagementCertificate#rule_type}.</summary>
            [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
