using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateRules")]
    public class CertificatesManagementCertificateCertificateRules : oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#advance_renewal_period CertificatesManagementCertificate#advance_renewal_period}.</summary>
        [JsiiProperty(name: "advanceRenewalPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public string AdvanceRenewalPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#renewal_interval CertificatesManagementCertificate#renewal_interval}.</summary>
        [JsiiProperty(name: "renewalInterval", typeJson: "{\"primitive\":\"string\"}")]
        public string RenewalInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate#rule_type CertificatesManagementCertificate#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleType
        {
            get;
            set;
        }
    }
}
